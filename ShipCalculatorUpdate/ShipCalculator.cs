using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ShipCalculatorUpdate
{
	public static class ShipCalculator
	{
		public static int CalculateHull(string size, bool isBoriEnabled, string quality, Dictionary<string, int> hullBySize, Dictionary<string, double> buildQuality)
		{
			if (!hullBySize.ContainsKey(size))
			{
				throw new ArgumentException("Размер '" + size + "' отсутствует в словаре HullBySize.");
			}
			int num = hullBySize[size];
			double num2 = (buildQuality.ContainsKey(quality) ? buildQuality[quality] : 1.0);
			int num3 = (int)((double)num * num2);
			if (!isBoriEnabled)
			{
				return num3;
			}
			return num3 * 3;
		}

		public static int CalculateArmor(string size, string shipClass, bool hasArmorAmplifier, bool isStalEnabled, string quality, int armorThiccPercent, Dictionary<string, int> armorBySize, Dictionary<string, double> armorMods, Dictionary<string, double> buildQuality)
		{
			if (!armorBySize.ContainsKey(size))
			{
				throw new ArgumentException("Размер '" + size + "' отсутствует в словаре ArmorSize.");
			}
			if (!armorMods.ContainsKey(shipClass))
			{
				throw new ArgumentException("Класс '" + shipClass + "' отсутствует в словаре ArmorMod.");
			}
			int num = armorBySize[size];
			double num2 = armorMods[shipClass];
			int num3 = (int)((double)num * num2);
			double num4 = (buildQuality.ContainsKey(quality) ? buildQuality[quality] : 1.0);
			num3 = (int)((double)num3 * num4);
			if (hasArmorAmplifier)
			{
				num3 *= 2;
			}
			if (isStalEnabled)
			{
				num3 *= 3;
			}
			if (armorThiccPercent < 0 || armorThiccPercent > 500)
			{
				throw new ArgumentException("Процентное значение брони должно быть в пределах от 0 до 500.");
			}
			return (int)((double)num3 * ((double)armorThiccPercent / 100.0));
		}

		public static int CalculateShield(string size, string shipClass, bool hasShieldAmplifier, bool isHassEnabled, string quality, Dictionary<string, int> shieldsBySize, Dictionary<string, double> shieldsMods, Dictionary<string, double> buildQuality)
		{
			if (!shieldsBySize.ContainsKey(size))
			{
				throw new ArgumentException("Размер '" + size + "' отсутствует в словаре ShieldsSize.");
			}
			if (!shieldsMods.ContainsKey(shipClass))
			{
				throw new ArgumentException("Класс '" + shipClass + "' отсутствует в словаре ShieldsMod.");
			}
			int num = shieldsBySize[size];
			double num2 = shieldsMods[shipClass];
			int num3 = (int)((double)num * num2);
			double num4 = (buildQuality.ContainsKey(quality) ? buildQuality[quality] : 1.0);
			num3 = (int)((double)num3 * num4);
			if (hasShieldAmplifier)
			{
				num3 *= 2;
			}
			if (isHassEnabled)
			{
				num3 *= 3;
			}
			return num3;
		}

		public static int CalculateAgility(string size, string shipClass, double armorThiccPercent, bool hasExhaustAccelerator, bool hasAdvancedManeuveringSystem, string quality, Dictionary<string, int> maneuverabilityBySize, Dictionary<string, double> maneuverabilityMod, Dictionary<string, double> buildQuality)
		{
			if (!maneuverabilityBySize.ContainsKey(size))
			{
				throw new ArgumentException("Размер '" + size + "' отсутствует в словаре ManeuverabilityBySize.");
			}
			int num = maneuverabilityBySize[size];
			double num2 = (maneuverabilityMod.ContainsKey(shipClass) ? maneuverabilityMod[shipClass] : 1.0);
			double num3 = (double)num * num2;
			double num4 = (buildQuality.ContainsKey(quality) ? buildQuality[quality] : 1.0);
			num3 *= num4;
			if (armorThiccPercent < 0.0 || armorThiccPercent > 500.0)
			{
				throw new ArgumentException("Процентное значение брони должно быть в диапазоне от 0 до 500.");
			}
			double num5 = 2.0 - armorThiccPercent / 500.0 * 1.8;
			num3 *= num5;
			if (hasExhaustAccelerator)
			{
				num3 *= 2.0;
			}
			if (hasAdvancedManeuveringSystem)
			{
				num3 *= 2.0;
			}
			return (int)Math.Min(num3, 10000.0);
		}

		public static int CalculateCrew(string size, Dictionary<string, int> crewBySize)
		{
			if (!crewBySize.ContainsKey(size))
			{
				throw new ArgumentException("Размер '" + size + "' отсутствует в словаре CrewBySize.");
			}
			return crewBySize[size];
		}

		public static bool CanAddWeapon(string weaponName, string size, string weaponType, bool isForward, Dictionary<string, (int Cost, bool LargeBase, bool ForwardOnly, bool MediumArm, bool HeavyArm, bool ExtremeArm)> weapons)
		{
			if (!weapons.ContainsKey(weaponName))
			{
				throw new ArgumentException("Оружие '" + weaponName + "' не найдено в словаре Weapons.");
			}
			(int Cost, bool LargeBase, bool ForwardOnly, bool MediumArm, bool HeavyArm, bool ExtremeArm) tuple = weapons[weaponName];
			bool item = tuple.LargeBase;
			bool item2 = tuple.ForwardOnly;
			bool item3 = tuple.MediumArm;
			bool item4 = tuple.HeavyArm;
			bool item5 = tuple.ExtremeArm;
			if (item)
			{
				switch (size)
				{
				case "C":
				case "SSS":
				case "SS":
				case "S":
					return false;
				}
			}
			if (item5)
			{
				switch (size)
				{
				case "C":
				case "SSS":
				case "SS":
				case "S":
				case "M":
				case "L":
				case "VL":
				case "A":
					return false;
				}
			}
			if (item4)
			{
				switch (size)
				{
				case "C":
				case "SSS":
				case "SS":
				case "S":
					return false;
				}
			}
			if (item3 && size == "C")
			{
				return false;
			}
			if (item2 && !isForward)
			{
				return false;
			}
			return true;
		}

		public static int CalculateWeaponLimit(string size, string weaponType, bool isForward, Dictionary<string, int> forwardWeaponsBySize, Dictionary<string, int> turretsBySize, Dictionary<string, int> turretWeapMod, string shipClass)
		{
			if (isForward)
			{
				if (!forwardWeaponsBySize.ContainsKey(size))
				{
					return 0;
				}
				return forwardWeaponsBySize[size];
			}
			if (turretsBySize.ContainsKey(size))
			{
				int num = turretsBySize[size];
				int num2 = (turretWeapMod.ContainsKey(shipClass) ? turretWeapMod[shipClass] : 0);
				return num + num2;
			}
			return 0;
		}

		public static int CalculateReactorOutput(string size, string shipClass, string buildQuality, Dictionary<string, int> reactorBySize, Dictionary<string, int> reactorMod, Dictionary<string, double> buildQualityModifiers)
		{
			int num = (reactorBySize.ContainsKey(size) ? reactorBySize[size] : 0);
			int num2 = (reactorMod.ContainsKey(shipClass) ? reactorMod[shipClass] : 0);
			double num3 = (buildQualityModifiers.ContainsKey(buildQuality) ? buildQualityModifiers[buildQuality] : 1.0);
			return (int)((double)(num + num2) * num3);
		}

		public static int CalculateEnergyConsumption(ListBox addedCivilSlots, ListBox addedSpecialSlots, ListBox frontWeapons, ListBox turretWeapons, string shipClass, Dictionary<string, (int EnergyCostCell, int CellSize)> energyCostAndSizeByItem, Dictionary<string, List<(string Name, int Count)>> freeSlotsByClass)
		{
			int num = 0;
			foreach (string item in addedCivilSlots.Items)
			{
				if (energyCostAndSizeByItem.ContainsKey(item))
				{
					num += energyCostAndSizeByItem[item].EnergyCostCell;
				}
			}
			foreach (string item2 in addedSpecialSlots.Items)
			{
				if (energyCostAndSizeByItem.ContainsKey(item2))
				{
					num += energyCostAndSizeByItem[item2].EnergyCostCell;
				}
			}
			foreach (string item3 in frontWeapons.Items)
			{
				if (energyCostAndSizeByItem.ContainsKey(item3))
				{
					num += energyCostAndSizeByItem[item3].EnergyCostCell;
				}
			}
			foreach (string item4 in turretWeapons.Items)
			{
				if (energyCostAndSizeByItem.ContainsKey(item4))
				{
					num += energyCostAndSizeByItem[item4].EnergyCostCell;
				}
			}
			foreach (var item5 in GetFreeSlotsForClass(shipClass, freeSlotsByClass))
			{
				if (energyCostAndSizeByItem.ContainsKey(item5.Name))
				{
					num += energyCostAndSizeByItem[item5.Name].EnergyCostCell * item5.Count;
				}
			}
			return num;
		}

		public static string CalculateSpeed(string engineType, string selectedSize, string selectedClass, ListBox pickedEngines, Dictionary<string, int> engineTechLevels, Dictionary<string, double> sizeModifiers, Dictionary<string, double> speedClassModifiers, Dictionary<string, double> engineTypeModifiers)
		{
			int num = 100;
			int sizePenalty = GetSizePenalty(selectedSize);
			if (sizePenalty == -1)
			{
				return "N/A";
			}
			List<string> list = (from string engine in pickedEngines.Items
				where engine.Contains(engineType)
				select engine).ToList();
			if (!list.Any())
			{
				return "N/A";
			}
			int num2 = 0;
			int num3 = 0;
			double num4 = 1.0;
			foreach (string item in list)
			{
				if (item.Contains("1 уровень"))
				{
					num2 = Math.Max(num2, 1);
				}
				else if (item.Contains("2 уровень"))
				{
					num2 = Math.Max(num2, 2);
				}
				else if (item.Contains("3 уровень"))
				{
					num2 = Math.Max(num2, 3);
				}
				else if (item.Contains("4 уровень"))
				{
					num2 = Math.Max(num2, 4);
				}
				if (item.Contains("Малый"))
				{
					num4 = 1.5;
				}
				else if (item.Contains("Средний"))
				{
					num4 = 2.0;
				}
				else if (item.Contains("Большой"))
				{
					num4 = 3.0;
				}
				num3++;
			}
			num3 = Math.Min(num3, 4);
			double num5 = (speedClassModifiers.ContainsKey(selectedClass) ? speedClassModifiers[selectedClass] : 1.0);
			double num6 = (engineTypeModifiers.ContainsKey(engineType) ? engineTypeModifiers[engineType] : 1.0);
			return Math.Round((double)((num - sizePenalty) * num2 * num3) * num4 * num5 * num6).ToString();
		}

		private static int GetSizePenalty(string size)
		{
			int num = new List<string>
			{
				"C", "SSS", "SS", "S", "M", "L", "VL", "A", "X", "XL",
				"XXL", "XXXL", "E", "XE"
			}.IndexOf(size);
			if (num == -1)
			{
				return -1;
			}
			return num * 7;
		}

		public static int CalculateStorageCapacity(string storageType, string selectedSize, string selectedClass, ListBox storageListBox, Dictionary<string, int> storageCapacitiesByType, Dictionary<string, Dictionary<string, double>> classSpecificModifiers)
		{
			int num = 0;
			if (storageType == "Склад общий")
			{
				num = 50;
			}
			else if (storageType == "Склад топлива")
			{
				num = ((selectedSize == "C") ? 50 : 50);
			}
			int num2 = 0;
			if (storageType != "Склад топлива")
			{
				string category = "C";
				if (selectedSize != "C")
				{
					category = GetSizeCategory(selectedSize);
				}
				double externalModifier = 1.0;
				if (classSpecificModifiers.ContainsKey(selectedClass) && classSpecificModifiers[selectedClass].ContainsKey(storageType))
				{
					externalModifier = classSpecificModifiers[selectedClass][storageType];
				}
				num2 = CalculateModulesCount(storageListBox.Items.Cast<string>().ToList(), storageType, externalModifier, category, storageCapacitiesByType, 0);
			}
			else
			{
				foreach (string item in storageListBox.Items)
				{
					if (item == storageType)
					{
						num2 = CalculateModulesCount(storageListBox.Items.Cast<string>().ToList(), storageType, 1.0, "Fuel", storageCapacitiesByType, 0);
					}
				}
			}
			return num + num2;
		}

		public static int CalculateModulesCount(List<string> items, string targetModuleType, double externalModifier, string Category, Dictionary<string, int> CapacitiesByType, int DopModules)
		{
			int num = items.Count((string item) => item == targetModuleType);
			if (num == 0)
			{
				return 0;
			}
			if (!CapacitiesByType.TryGetValue(Category, out var value))
			{
				throw new ArgumentException("Неизвестная категория: " + Category);
			}
			Dictionary<int, int> dictionary = CombineModules(num + DopModules);
			int num2 = 0;
			foreach (KeyValuePair<int, int> item in dictionary)
			{
				num2 += (int)((double)(item.Value * value) * Math.Pow(3.0, item.Key - 1) * externalModifier);
			}
			return num2;
		}

		public static Dictionary<int, int> CombineModules(int initialModuleCount)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int> { { 1, initialModuleCount } };
			while (dictionary.Any((KeyValuePair<int, int> level) => level.Value >= 2))
			{
				Dictionary<int, int> dictionary2 = new Dictionary<int, int>(dictionary);
				foreach (KeyValuePair<int, int> item in dictionary)
				{
					if (item.Value >= 2)
					{
						int num = item.Value / 2;
						int value = item.Value % 2;
						if (!dictionary2.ContainsKey(item.Key + 1))
						{
							dictionary2[item.Key + 1] = 0;
						}
						dictionary2[item.Key + 1] += num;
						dictionary2[item.Key] = value;
					}
				}
				dictionary = dictionary2;
			}
			return dictionary;
		}

		public static int CalculatePerformance(Dictionary<int, int> modulesByLevel, int moduleProductivity)
		{
			int num = 0;
			foreach (KeyValuePair<int, int> item in modulesByLevel)
			{
				num += item.Value * moduleProductivity * (int)Math.Pow(3.0, item.Value - 1);
			}
			return num;
		}

		private static string GetSizeCategory(string size)
		{
			if (size == "C")
			{
				return "C";
			}
			if (new string[3] { "SSS", "SS", "S" }.Contains(size))
			{
				return "Light";
			}
			if (new string[4] { "M", "L", "VL", "A" }.Contains(size))
			{
				return "Medium";
			}
			if (new string[4] { "X", "XL", "XXL", "XXXL" }.Contains(size))
			{
				return "Heavy";
			}
			if (new string[2] { "E", "XE" }.Contains(size))
			{
				return "SuperHeavy";
			}
			return "Unknown";
		}

		public static int CalculateHangarCapacity(string hangarType, string selectedClass, ListBox hangarListBox, Dictionary<string, int> hangarCapacitiesByType, Dictionary<string, Dictionary<string, double>> classSpecificModifiers, Dictionary<string, List<(string Name, int Count)>> freeSlotsByClass)
		{
			List<(string, int)> freeSlotsForClass = GetFreeSlotsForClass(selectedClass, freeSlotsByClass);
			return CalculateModulesCount(hangarListBox.Items.Cast<string>().ToList(), hangarType, 1.0, hangarType, hangarCapacitiesByType, freeSlotsForClass.Count);
		}

		public static List<(string Name, int Count)> GetFreeSlotsForClass(string shipClass, Dictionary<string, List<(string Name, int Count)>> freeSlotsByClass)
		{
			if (!freeSlotsByClass.ContainsKey(shipClass))
			{
				return new List<(string, int)>();
			}
			return freeSlotsByClass[shipClass];
		}

		public static int CalculateCost(string shipSize, string shipClass, string buildQuality, ListBox enginesListBox, List<string> sensorsList, ListBox frontWeaponsListBox, ListBox turretWeaponsListBox, ListBox addedCivilSlotListBox, ListBox addedSpecialSlotListBox, string priceAddModifier, double armorThickness, bool boriCheck, bool stalCheck, bool hassCheck, Dictionary<string, int> shipSizeCosts, Dictionary<string, double> shipClassCostModifiers, Dictionary<string, double> buildQualityModifiers, Dictionary<string, int> sensorCosts, Dictionary<string, (int Cost, bool LargeBase, bool ForwardOnly, bool MediumArm, bool HeavyArm, bool ExtremeArm)> weapons, Dictionary<string, int> civilianCellCosts, Dictionary<string, int> specialCellCosts, Dictionary<string, double> priceAddModifiers)
		{
			int num = (shipSizeCosts.ContainsKey(shipSize) ? shipSizeCosts[shipSize] : 0);
			double num2 = (shipClassCostModifiers.ContainsKey(shipClass) ? shipClassCostModifiers[shipClass] : 1.0);
			double num3 = (buildQualityModifiers.ContainsKey(buildQuality) ? buildQualityModifiers[buildQuality] : 1.0);
			int num4 = 0;
			foreach (string item in enginesListBox.Items)
			{
				int num5 = (item.Contains("I") ? 1 : (item.Contains("II") ? 2 : (item.Contains("III") ? 3 : ((!item.Contains("IV")) ? 1 : 4))));
				num4 += (int)((double)num * 0.1 * (double)num5);
			}
			int num6 = 0;
			foreach (string sensors in sensorsList)
			{
				num6 += (sensorCosts.ContainsKey(sensors) ? sensorCosts[sensors] : 0);
			}
			double num7 = Math.Max(0.33, Math.Min(1.5, armorThickness / 100.0));
			double num8 = 1.0;
			if (boriCheck)
			{
				num8 += 0.33;
			}
			if (stalCheck)
			{
				num8 += 0.33;
			}
			if (hassCheck)
			{
				num8 += 0.33;
			}
			int num9 = 0;
			foreach (string item2 in frontWeaponsListBox.Items)
			{
				num9 += (weapons.ContainsKey(item2) ? weapons[item2].Cost : 0);
			}
			foreach (string item3 in turretWeaponsListBox.Items)
			{
				num9 += (weapons.ContainsKey(item3) ? weapons[item3].Cost : 0);
			}
			int num10 = 0;
			foreach (string item4 in addedCivilSlotListBox.Items)
			{
				num10 += (civilianCellCosts.ContainsKey(item4) ? civilianCellCosts[item4] : 0);
			}
			foreach (string item5 in addedSpecialSlotListBox.Items)
			{
				num10 += (specialCellCosts.ContainsKey(item5) ? specialCellCosts[item5] : 0);
			}
			double num11 = (priceAddModifiers.ContainsKey(priceAddModifier) ? priceAddModifiers[priceAddModifier] : 1.0);
			return (int)Math.Round(((double)num * num2 * num3 + (double)(num4 + num6 + num9 + num10)) * (num7 * num8 * num11));
		}

		public static int CalculateWeaponSlotUsage(ListBox weaponListBox, Dictionary<string, (int EnergyCostCell, int CellSize)> energyCostAndSizeByItem)
		{
			int num = 0;
			foreach (object item in weaponListBox.Items)
			{
				string key = item.ToString();
				num = ((!energyCostAndSizeByItem.ContainsKey(key)) ? (num + 1) : (num + energyCostAndSizeByItem[key].CellSize));
			}
			return num;
		}

		public static int CalculateCivilSlotLimit(ListBox AddedCivilSlotListBox, Dictionary<string, (int EnergyCostCell, int CellSize)> energyCostAndSizeByItem)
		{
			int num = 0;
			foreach (object item in AddedCivilSlotListBox.Items)
			{
				string key = item.ToString();
				num = ((!energyCostAndSizeByItem.ContainsKey(key)) ? (num + 1) : (num + energyCostAndSizeByItem[key].CellSize));
			}
			return num;
		}

		public static int CalculateSpecialSlotLimit(ListBox AddedSpecialSlotListBox, Dictionary<string, (int EnergyCostCell, int CellSize)> energyCostAndSizeByItem)
		{
			int num = 0;
			foreach (object item in AddedSpecialSlotListBox.Items)
			{
				string key = item.ToString();
				num = ((!energyCostAndSizeByItem.ContainsKey(key)) ? (num + 1) : (num + energyCostAndSizeByItem[key].CellSize));
			}
			return num;
		}
	}
}
