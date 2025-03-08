using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using ShipConfigurator;

namespace ShipCalculatorUpdate
{
	public class Form1 : Form
	{
		private int _maneuverEngineLevel;

		private TabControl TabControl1;

		private TabPage TabPage1;

		private TabPage TabPage2;

		private GroupBox MainGroupBox;

		private LinkLabel RulesLinkLabel;

		private Button SaveButton;

		private Label CostLabel;

		private MenuStrip MenuStrip1;

		private ToolStripMenuItem ToolStripMenu;

		private ToolStripMenuItem changeLogsToolStripMenuItem;

		private ComboBox QualityComboBox;

		private Label QualityLabel;

		private ComboBox ClassComboBox;

		private Label ClassLabel;

		private ComboBox SizeComboBox;

		private Label SizeLabel;

		private TextBox NameTextBox;

		private Label NameLabel;

		private GroupBox EnginesGroupBox;

		private CheckedListBox SensorsCheckedListBox;

		private Label SensorsLabel;

		private Label AgilityLabel;

		private Label ShieldLabel;

		private Label ArmorLabel;

		private Label HullLabel;

		private ToolStripMenuItem описаниеМодулейToolStripMenuItem;

		private GroupBox AddOnGroupBox;

		private Label ReactorLabel;

		private Label ControlUnitLabel;

		private ComboBox ControlUnitComboBox;

		private CheckBox HassCheckBox;

		private Label CrewLabel;

		private TabPage TabPage3;

		private TextBox ArmorThiccTextBox;

		private Label ArmorThiccLabel;

		private CheckBox BoriCheckBox;

		private CheckBox StalCheckBox;

		private Label PriceAddLabel;

		private ComboBox PriceAddComboBox;

		private Label GMLabel;

		private ComboBox EngineSizeComboBox;

		private ListBox PickedEnginesListBox;

		private ListBox EnginesListBox;

		private Label EnginesSizeLabel;

		private Button RemoveEngineButton;

		private Button AddEngineButton;

		private Label EnginesTipLabel;

		private TextBox DescTextBox;

		private Label DescLabel;

		private GroupBox SecPropGroupBox;

		private TextBox InventoryTextBox;

		private Label InventoryLabel;

		private Label SingleUseSpeedLabel;

		private Label AtmoSpeedLabel;

		private Label SpaceSpeedLabel;

		private Label BaseSpeedLabel;

		private GroupBox SpeedsGroupBox;

		private Label CargoCapLabel;

		private Label HangarCapLabel;

		private Label TurretWeapLabel;

		private Label FrontWeapLabel;

		private Label WeaponsLabel;

		private ListBox TurretWeapListBox;

		private ListBox FrontWeapListBox;

		private ListBox WeaponsListBox;

		private TextBox TurretWeapNumTextBox;

		private TextBox FrontWeapNumTextBox;

		private Label TurretNumLabel;

		private Label FrontNumLabel;

		private Button AddTurretWeapButton;

		private Button AddFrontWeapButton;

		private Label AmmoCapLabel;

		private Label FuelCapLabel;

		private Button RemoveAllTurretWeapButton;

		private Button RemoveAllFrontWeapButton;

		private Button RemoveTurretWeapButton;

		private Button RemoveFrontWeapButton;

		private GroupBox CurrentWeapGroupBox;

		private GroupBox ParametrsGroupBox;

		private GroupBox SpecialSlotsGroupBox;

		private GroupBox CivilSlotsGroupBox;

		private Label CivilSlotsLabel;

		private Label SpecialSlotsLabel;

		private Label TurretWeapCapLabel;

		private Label FrontWeapCapLabel;

		private ListBox AddedSpecialSlotListBox;

		private Button AddSpecialSlotButton;

		private ListBox SpecialSlotListBox;

		private ListBox AddedCivilSlotListBox;

		private Button AddCivilSlotButton;

		private ListBox CivilSlotListBox;

		private TextBox SpecialRemoveTextBox;

		private Label SpecialRemoveLabel;

		private Button RemoveSpecialSlotButton;

		private TextBox SpecialAddTextBox;

		private Label SpecialAddLabel;

		private TextBox CivilRemoveTextBox;

		private Label CivilRemoveLabel;

		private Button RemoveCivilSlotButton;

		private TextBox CivilAddTextBox;

		private Label CivilAddLlabel;

		private Label AddedSpecialSlotsLabel;

		private Label AddedCivilSlotsLabel;

		private Button RemoveAllCivilSlotButton;

		private Button RemoveAllSpecialSlotButton;

		private Label EngineTechLvlLabel;

		private ComboBox EngineTechComboBox;

		private Label ChelnokHangarCapLabel;

		private Label MedCapLabel;

		private ToolStripMenuItem LoadConfigurationButton;

		private int CivilSlotCapacity => ShipCalculator.CalculateCivilSlotLimit(AddedCivilSlotListBox, DictioneryStorage.EnergyCostAndSizeByItem);

		private int SpecialSlotCapacity => ShipCalculator.CalculateSpecialSlotLimit(AddedSpecialSlotListBox, DictioneryStorage.EnergyCostAndSizeByItem);

		private int FrontWeaponCapacity => ShipCalculator.CalculateWeaponLimit(SizeComboBox.SelectedItem?.ToString(), "Front", isForward: true, DictioneryStorage.ForwardWeaponsBySize, DictioneryStorage.TurretsBySize, DictioneryStorage.TurretWeapMod, ClassComboBox.SelectedItem?.ToString());

		private int TurretWeaponCapacity => ShipCalculator.CalculateWeaponLimit(SizeComboBox.SelectedItem?.ToString(), "Turret", isForward: false, DictioneryStorage.ForwardWeaponsBySize, DictioneryStorage.TurretsBySize, DictioneryStorage.TurretWeapMod, ClassComboBox.SelectedItem?.ToString());

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadData();
			InitializeSensors();
			InitializePriceAddComboBox();
			InitializeWeaponsListBox();
			InitializeCivilSlotListBox();
			InitializeSpecialSlotListBox();
			InitializeEnginesListBox();
			InitializeEngineSizeComboBox();
			InitializeControlUnitComboBox();
			InitializeEngineTechComboBox();
			SizeComboBox.SelectedIndexChanged += SizeComboBox_SelectedIndexChanged;
			ClassComboBox.SelectedIndexChanged += ClassComboBox_SelectedIndexChanged;
			SensorsCheckedListBox.ItemCheck += SensorsCheckedListBox_ItemCheck;
			QualityComboBox.SelectedIndexChanged += QualityComboBox_SelectedIndexChanged;
			BoriCheckBox.CheckedChanged += BoriCheckBox_CheckedChanged;
			ArmorThiccTextBox.TextChanged += ArmorThiccTextBox_TextChanged;
			HassCheckBox.CheckedChanged += HassCheckBox_CheckedChanged;
			AddedSpecialSlotListBox.SelectedIndexChanged += AddedSpecialSlotListBox_SelectedIndexChanged;
			AddedCivilSlotListBox.SelectedIndexChanged += AddedCivilSlotListBox_SelectedIndexChanged;
			ArmorThiccTextBox.Text = "100";
			UpdateCivilSlotLabel();
			UpdateHullLabel();
			UpdateArmorLabel();
			UpdateShieldLabel();
			UpdateAgilityLabel();
			UpdateCrewLabel();
			RecalculateAgilityFromEngines();
			UpdateWeaponLimits();
			UpdateReactorLabel();
			UpdateSpeedLabels();
			UpdateStorageAndHangarLabels();
			UpdateCostLabel();
		}

		private void LoadData()
		{
			SizeComboBox.Items.Clear();
			ComboBox.ObjectCollection items = SizeComboBox.Items;
			object[] items2 = DictioneryStorage.Sizes.ToArray();
			items.AddRange(items2);
			if (SizeComboBox.Items.Count > 0)
			{
				SizeComboBox.SelectedIndex = 0;
			}
			QualityComboBox.Items.Clear();
			ComboBox.ObjectCollection items3 = QualityComboBox.Items;
			items2 = DictioneryStorage.BuildQuality.Keys.ToArray();
			items3.AddRange(items2);
			if (QualityComboBox.Items.Count > 0)
			{
				QualityComboBox.SelectedIndex = 0;
			}
		}

		private void SizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string key = SizeComboBox.SelectedItem.ToString();
			if (DictioneryStorage.Classes.ContainsKey(key))
			{
				ClassComboBox.Items.Clear();
				ComboBox.ObjectCollection items = ClassComboBox.Items;
				object[] items2 = DictioneryStorage.Classes[key].ToArray();
				items.AddRange(items2);
				if (ClassComboBox.Items.Count > 0)
				{
					ClassComboBox.SelectedIndex = 0;
				}
			}
			else
			{
				ClassComboBox.Items.Clear();
			}
			UpdateCivilSlotLabel();
			UpdateHullLabel();
			UpdateArmorLabel();
			UpdateShieldLabel();
			UpdateAgilityLabel();
			UpdateCrewLabel();
			UpdateWeaponLimits();
			UpdateReactorLabel();
			UpdateSpeedLabels();
			UpdateStorageAndHangarLabels();
			UpdateCostLabel();
			ClearAllRelevantLists();
			UpdateWeaponLimits();
		}

		private void ClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string key = ClassComboBox.SelectedItem.ToString();
			if (DictioneryStorage.DescriptionClass.ContainsKey(key))
			{
				DescTextBox.Text = string.Join(Environment.NewLine, DictioneryStorage.DescriptionClass[key]);
			}
			else
			{
				DescTextBox.Text = "Описание недоступно.";
			}
			UpdateCivilSlotLabel();
			UpdateSpecialSlotLabel();
			UpdateArmorLabel();
			UpdateShieldLabel();
			UpdateAgilityLabel();
			UpdateWeaponLimits();
			UpdateReactorLabel();
			UpdateSpeedLabels();
			UpdateStorageAndHangarLabels();
			UpdateCostLabel();
			ClearAllRelevantLists();
			UpdateWeaponLimits();
		}

		private void InitializeSensors()
		{
			SensorsCheckedListBox.Items.Clear();
			SensorsCheckedListBox.Items.Add("Радиолокационные");
			SensorsCheckedListBox.Items.Add("Магнитные");
			SensorsCheckedListBox.Items.Add("Оптические");
		}

		private void HandleSensorSelection(string sensorType, CheckState state)
		{
			if (state == CheckState.Checked)
			{
			}
		}

		private void SensorsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			string sensorType = SensorsCheckedListBox.Items[e.Index].ToString();
			HandleSensorSelection(sensorType, e.NewValue);
			UpdateCostLabel();
		}

		private void InitializePriceAddComboBox()
		{
			PriceAddComboBox.Items.Clear();
			foreach (KeyValuePair<string, double> item in DictioneryStorage.PriceAdd)
			{
				PriceAddComboBox.Items.Add(item.Key);
			}
			if (PriceAddComboBox.Items.Count > 0)
			{
				PriceAddComboBox.SelectedIndex = 0;
			}
		}

		private void InitializeWeaponsListBox()
		{
			WeaponsListBox.Items.Clear();
			foreach (string key in DictioneryStorage.Weapons.Keys)
			{
				WeaponsListBox.Items.Add(key);
			}
		}

		private void InitializeCivilSlotListBox()
		{
			CivilSlotListBox.Items.Clear();
			foreach (string key in DictioneryStorage.CivilianCellCosts.Keys)
			{
				CivilSlotListBox.Items.Add(key);
			}
		}

		private void InitializeSpecialSlotListBox()
		{
			SpecialSlotListBox.Items.Clear();
			foreach (string key in DictioneryStorage.SpecialCellCosts.Keys)
			{
				SpecialSlotListBox.Items.Add(key);
			}
		}

		private void InitializeEnginesListBox()
		{
			EnginesListBox.Items.Clear();
			EnginesListBox.Items.Add("Маневровый");
			EnginesListBox.Items.Add("Космический");
			EnginesListBox.Items.Add("Атмосферный");
			EnginesListBox.Items.Add("Одноразовый");
		}

		private void InitializeEngineSizeComboBox()
		{
			EngineSizeComboBox.Items.Clear();
			EngineSizeComboBox.Items.Add("Большой");
			EngineSizeComboBox.Items.Add("Средний");
			EngineSizeComboBox.Items.Add("Малый");
			if (EngineSizeComboBox.Items.Count > 0)
			{
				EngineSizeComboBox.SelectedIndex = 0;
			}
		}

		private void InitializeControlUnitComboBox()
		{
			ControlUnitComboBox.Items.Clear();
			foreach (string key in DictioneryStorage.ControlUnitCosts.Keys)
			{
				ControlUnitComboBox.Items.Add(key);
			}
			if (ControlUnitComboBox.Items.Count > 0)
			{
				ControlUnitComboBox.SelectedIndex = 0;
			}
		}

		private int GetCivilSlotLimit()
		{
			string key = SizeComboBox.SelectedItem?.ToString() ?? "";
			string key2 = ClassComboBox.SelectedItem?.ToString() ?? "";
			int num = (DictioneryStorage.CivCellSize.ContainsKey(key) ? DictioneryStorage.CivCellSize[key] : 0);
			int num2 = (DictioneryStorage.CivCellMod.ContainsKey(key2) ? DictioneryStorage.CivCellMod[key2] : 0);
			return num + num2;
		}

		private void UpdateCivilSlotLabel()
		{
			string selectedClass = ClassComboBox.SelectedItem?.ToString() ?? "";
			int num2 = AddedCivilSlotListBox.Items.Cast<string>().Sum(delegate(string item)
			{
				if (!DictioneryStorage.EnergyCostAndSizeByItem.ContainsKey(item))
				{
					return 0;
				}
				int num = DictioneryStorage.EnergyCostAndSizeByItem[item].CellSize;
				if ((item == "Ангар общего назначения" || item == "Ангар для челноков") && (selectedClass == "Станция" || selectedClass == "Авианосец"))
				{
					num = Math.Max(1, num / 5);
				}
				return num;
			});
			int civilSlotLimit = GetCivilSlotLimit();
			AddedCivilSlotsLabel.Text = $"Занятые слоты: {num2}/{civilSlotLimit}";
		}

		private void AddCivilSlotButton_Click(object sender, EventArgs e)
		{
			if (CivilSlotListBox.SelectedItem == null || string.IsNullOrWhiteSpace(CivilAddTextBox.Text))
			{
				MessageBox.Show("Выберите элемент и укажите количество для добавления.");
				return;
			}
			string text = CivilSlotListBox.SelectedItem.ToString();
			string selectedClass = ClassComboBox.SelectedItem?.ToString() ?? "";
			if (DictioneryStorage.UniqueCivilSlots.Contains(text) && AddedCivilSlotListBox.Items.Contains(text))
			{
				MessageBox.Show("Элемент '" + text + "' можно добавить только один раз.", "Ошибка");
				return;
			}
			if (!int.TryParse(CivilAddTextBox.Text, out var result) || result <= 0)
			{
				MessageBox.Show("Укажите корректное количество для добавления.");
				return;
			}
			int num = (DictioneryStorage.EnergyCostAndSizeByItem.ContainsKey(text) ? DictioneryStorage.EnergyCostAndSizeByItem[text].CellSize : 0);
			if (num == 0)
			{
				MessageBox.Show("Не удалось определить размер выбранного элемента.");
				return;
			}
			if ((text == "Ангар общего назначения" || text == "Ангар для челноков") && (selectedClass == "Станция" || selectedClass == "Авианосец"))
			{
				num = Math.Max(1, num / 5);
			}
			int num3 = AddedCivilSlotListBox.Items.Cast<string>().Sum(delegate(string item)
			{
				int num2 = (DictioneryStorage.EnergyCostAndSizeByItem.ContainsKey(item) ? DictioneryStorage.EnergyCostAndSizeByItem[item].CellSize : 0);
				if ((item == "Ангар общего назначения" || item == "Ангар для челноков") && (selectedClass == "Станция" || selectedClass == "Авианосец"))
				{
					num2 = Math.Max(1, num2 / 5);
				}
				return num2;
			});
			int civilSlotLimit = GetCivilSlotLimit();
			if (num3 + num * result > civilSlotLimit)
			{
				MessageBox.Show($"Превышен лимит гражданских слотов: {civilSlotLimit}");
				return;
			}
			if (!DictioneryStorage.UniqueCivilSlots.Contains(text))
			{
				for (int i = 0; i < result; i++)
				{
					AddedCivilSlotListBox.Items.Add(text);
				}
			}
			else
			{
				AddedCivilSlotListBox.Items.Add(text);
			}
			UpdateCivilSlotLabel();
			UpdateStorageAndHangarLabels();
			UpdateCostLabel();
		}

		private void RemoveCivilSlotButton_Click(object sender, EventArgs e)
		{
			if (AddedCivilSlotListBox.SelectedItem == null)
			{
				MessageBox.Show("Выберите элемент для удаления.");
				return;
			}
			if (string.IsNullOrWhiteSpace(CivilRemoveTextBox.Text))
			{
				MessageBox.Show("Укажите количество для удаления.");
				return;
			}
			if (!int.TryParse(CivilRemoveTextBox.Text, out var result) || result <= 0)
			{
				MessageBox.Show("Укажите корректное количество для удаления.");
				return;
			}
			string selectedSlot = AddedCivilSlotListBox.SelectedItem.ToString();
			int num = AddedCivilSlotListBox.Items.Cast<string>().Count((string item) => item == selectedSlot);
			if (result > num)
			{
				MessageBox.Show($"Вы не можете удалить больше, чем {num} экземпляров элемента '{selectedSlot}'.");
				return;
			}
			for (int i = 0; i < result; i++)
			{
				AddedCivilSlotListBox.Items.Remove(selectedSlot);
			}
			UpdateCivilSlotLabel();
			UpdateStorageAndHangarLabels();
			UpdateCostLabel();
		}

		private void RemoveAllCivilSlotButton_Click(object sender, EventArgs e)
		{
			AddedCivilSlotListBox.Items.Clear();
			UpdateCivilSlotLabel();
			UpdateStorageAndHangarLabels();
			UpdateCostLabel();
		}

		private void AddSpecialSlotButton_Click(object sender, EventArgs e)
		{
			if (SpecialSlotListBox.SelectedItem == null || string.IsNullOrWhiteSpace(SpecialAddTextBox.Text))
			{
				MessageBox.Show("Выберите элемент и укажите количество для добавления.");
				return;
			}
			string text = SpecialSlotListBox.SelectedItem.ToString();
			if (DictioneryStorage.UniqueSpecialSlots.Contains(text) && AddedSpecialSlotListBox.Items.Contains(text))
			{
				MessageBox.Show("Элемент '" + text + "' можно добавить только один раз.", "Ошибка");
				return;
			}
			if (!int.TryParse(SpecialAddTextBox.Text, out var result) || result <= 0)
			{
				MessageBox.Show("Укажите корректное количество для добавления.");
				return;
			}
			int num = (DictioneryStorage.EnergyCostAndSizeByItem.ContainsKey(text) ? DictioneryStorage.EnergyCostAndSizeByItem[text].CellSize : 0);
			if (num == 0)
			{
				MessageBox.Show("Не удалось определить размер выбранного элемента.");
				return;
			}
			int num2 = AddedSpecialSlotListBox.Items.Cast<string>().Sum((string item) => DictioneryStorage.EnergyCostAndSizeByItem.ContainsKey(item) ? DictioneryStorage.EnergyCostAndSizeByItem[item].CellSize : 0);
			int specialSlotLimit = GetSpecialSlotLimit();
			if (num2 + num * result > specialSlotLimit)
			{
				MessageBox.Show($"Превышен лимит специальных слотов: {specialSlotLimit}");
				return;
			}
			if (!DictioneryStorage.UniqueSpecialSlots.Contains(text))
			{
				for (int i = 0; i < result; i++)
				{
					AddedSpecialSlotListBox.Items.Add(text);
				}
			}
			else
			{
				AddedSpecialSlotListBox.Items.Add(text);
			}
			UpdateSpecialSlotLabel();
			UpdateCostLabel();
		}

		private void UpdateSpecialSlotLabel()
		{
			int num = AddedSpecialSlotListBox.Items.Cast<string>().Sum((string item) => DictioneryStorage.EnergyCostAndSizeByItem.ContainsKey(item) ? DictioneryStorage.EnergyCostAndSizeByItem[item].CellSize : 0);
			int specialSlotLimit = GetSpecialSlotLimit();
			AddedSpecialSlotsLabel.Text = $"Занятые слоты: {num}/{specialSlotLimit}";
		}

		private int GetSpecialSlotLimit()
		{
			string text = ClassComboBox.SelectedItem?.ToString() ?? "";
			if (!DictioneryStorage.SpecCells.ContainsKey(text))
			{
				MessageBox.Show("Класс '" + text + "' отсутствует в SpecCells.", "Ошибка данных");
				return 0;
			}
			return DictioneryStorage.SpecCells[text];
		}

		private void RemoveSpecialSlotButton_Click(object sender, EventArgs e)
		{
			if (AddedSpecialSlotListBox.SelectedItem == null)
			{
				MessageBox.Show("Выберите элемент для удаления.");
				return;
			}
			if (string.IsNullOrWhiteSpace(SpecialRemoveTextBox.Text))
			{
				MessageBox.Show("Укажите количество для удаления.");
				return;
			}
			if (!int.TryParse(SpecialRemoveTextBox.Text, out var result) || result <= 0)
			{
				MessageBox.Show("Укажите корректное количество для удаления.");
				return;
			}
			string selectedSlot = AddedSpecialSlotListBox.SelectedItem.ToString();
			int num = AddedSpecialSlotListBox.Items.Cast<string>().Count((string item) => item == selectedSlot);
			if (result > num)
			{
				MessageBox.Show($"Вы не можете удалить больше, чем {num} экземпляров элемента '{selectedSlot}'.");
				return;
			}
			for (int i = 0; i < result; i++)
			{
				AddedSpecialSlotListBox.Items.Remove(selectedSlot);
			}
			UpdateSpecialSlotLabel();
			UpdateCostLabel();
		}

		private void RemoveAllSpecialSlotButton_Click(object sender, EventArgs e)
		{
			AddedSpecialSlotListBox.Items.Clear();
			UpdateSpecialSlotLabel();
			UpdateCostLabel();
		}

		private void UpdateHullLabel()
		{
			string text = SizeComboBox.SelectedItem?.ToString() ?? "";
			string text2 = QualityComboBox.SelectedItem?.ToString() ?? "";
			if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2))
			{
				HullLabel.Text = "Корпус: N/A";
				return;
			}
			bool @checked = BoriCheckBox.Checked;
			try
			{
				int num = ShipCalculator.CalculateHull(text, @checked, text2, DictioneryStorage.HullBySize, DictioneryStorage.BuildQuality);
				HullLabel.Text = $"Корпус: {num}";
			}
			catch (ArgumentException ex)
			{
				HullLabel.Text = "Корпус: ошибка";
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}

		private void BoriCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			UpdateHullLabel();
			UpdateCostLabel();
		}

		private void QualityComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateHullLabel();
			UpdateArmorLabel();
			UpdateShieldLabel();
			UpdateAgilityLabel();
			UpdateReactorLabel();
			UpdateCostLabel();
		}

		private void UpdateArmorLabel()
		{
			string text = SizeComboBox.SelectedItem?.ToString() ?? "";
			string text2 = ClassComboBox.SelectedItem?.ToString() ?? "";
			if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2))
			{
				ArmorLabel.Text = "Броня: N/A";
				return;
			}
			bool @checked = StalCheckBox.Checked;
			bool hasArmorAmplifier = AddedSpecialSlotListBox.Items.Cast<string>().Any((string item) => item == "Усилитель брони");
			string quality = QualityComboBox.SelectedItem?.ToString() ?? "";
			if (!int.TryParse(ArmorThiccTextBox.Text, out var result) || result < 0 || result > 500)
			{
				result = 100;
				ArmorThiccTextBox.Text = "100";
				MessageBox.Show("Введите значение толщины брони в диапазоне от 0% до 500%. Установлено значение 100%.", "Ошибка ввода");
			}
			try
			{
				int num = ShipCalculator.CalculateArmor(text, text2, hasArmorAmplifier, @checked, quality, result, DictioneryStorage.ArmorSize, DictioneryStorage.ArmorMod, DictioneryStorage.BuildQuality);
				ArmorLabel.Text = $"Броня: {num}";
			}
			catch (ArgumentException ex)
			{
				ArmorLabel.Text = "Броня: ошибка";
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}

		private void StalCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			UpdateArmorLabel();
			UpdateCostLabel();
		}

		private void AddedSpecialSlotListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateArmorLabel();
			UpdateShieldLabel();
			UpdateAgilityLabel();
			UpdateReactorLabel();
			UpdateCostLabel();
		}

		private void AddedCivilSlotListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateArmorLabel();
			UpdateShieldLabel();
			UpdateAgilityLabel();
			UpdateReactorLabel();
			UpdateStorageAndHangarLabels();
			UpdateCostLabel();
		}

		private void ArmorThiccTextBox_TextChanged(object sender, EventArgs e)
		{
			UpdateArmorLabel();
			UpdateAgilityLabel();
			UpdateCostLabel();
		}

		private void UpdateShieldLabel()
		{
			string text = SizeComboBox.SelectedItem?.ToString() ?? "";
			string text2 = ClassComboBox.SelectedItem?.ToString() ?? "";
			if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2))
			{
				ShieldLabel.Text = "Щит: N/A";
				return;
			}
			bool @checked = HassCheckBox.Checked;
			bool hasShieldAmplifier = AddedSpecialSlotListBox.Items.Cast<string>().Any((string item) => item == "Усилитель щита");
			string quality = QualityComboBox.SelectedItem?.ToString() ?? "";
			try
			{
				int num = ShipCalculator.CalculateShield(text, text2, hasShieldAmplifier, @checked, quality, DictioneryStorage.ShieldsSize, DictioneryStorage.ShieldsMod, DictioneryStorage.BuildQuality);
				ShieldLabel.Text = $"Щит: {num}";
			}
			catch (ArgumentException ex)
			{
				ShieldLabel.Text = "Щит: ошибка";
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}

		private void HassCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			UpdateShieldLabel();
			UpdateCostLabel();
		}

		private void UpdateAgilityLabel(int maneuverEngineLevel = -1)
		{
			if (maneuverEngineLevel == -1)
			{
				maneuverEngineLevel = _maneuverEngineLevel;
			}
			string text = SizeComboBox.SelectedItem?.ToString() ?? "";
			string text2 = ClassComboBox.SelectedItem?.ToString() ?? "";
			if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2))
			{
				AgilityLabel.Text = "Манёвренность: N/A";
				return;
			}
			bool hasExhaustAccelerator = AddedCivilSlotListBox.Items.Cast<string>().Any((string item) => item == "Ускоритель выхлопа");
			bool hasAdvancedManeuveringSystem = AddedSpecialSlotListBox.Items.Cast<string>().Any((string item) => item == "Система Прод. Маневрирования");
			if (!int.TryParse(ArmorThiccTextBox.Text, out var result))
			{
				MessageBox.Show("Введите корректное значение для толщины брони (0–500%).");
				return;
			}
			string quality = QualityComboBox.SelectedItem?.ToString() ?? "";
			try
			{
				int num = ShipCalculator.CalculateAgility(text, text2, result, hasExhaustAccelerator, hasAdvancedManeuveringSystem, quality, DictioneryStorage.ManeuverabilityBySize, DictioneryStorage.ManeuverabilityMod, DictioneryStorage.BuildQuality);
				if (maneuverEngineLevel > 0)
				{
					num *= maneuverEngineLevel;
				}
				AgilityLabel.Text = $"Манёвренность: {Math.Min(num, 10000)}";
			}
			catch (ArgumentException ex)
			{
				AgilityLabel.Text = "Манёвренность: ошибка";
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}

		private void UpdateCrewLabel()
		{
			string text = SizeComboBox.SelectedItem?.ToString() ?? "";
			if (string.IsNullOrEmpty(text))
			{
				CrewLabel.Text = "Экипаж: N/A";
				return;
			}
			try
			{
				int num = ShipCalculator.CalculateCrew(text, DictioneryStorage.CrewBySize);
				CrewLabel.Text = $"Экипаж: от {num}";
			}
			catch (ArgumentException ex)
			{
				CrewLabel.Text = "Экипаж: ошибка";
				MessageBox.Show(ex.Message, "Ошибка");
			}
		}

		private void InitializeEngineTechComboBox()
		{
			EngineTechComboBox.Items.Clear();
			foreach (string key in DictioneryStorage.EngineLvl.Keys)
			{
				EngineTechComboBox.Items.Add(key);
			}
			if (EngineTechComboBox.Items.Count > 0)
			{
				EngineTechComboBox.SelectedIndex = 0;
			}
		}

		private void AddEngineButton_Click(object sender, EventArgs e)
		{
			if (EnginesListBox.SelectedItem == null)
			{
				MessageBox.Show("Выберите тип двигателя.", "Ошибка");
			}
			else if (EngineSizeComboBox.SelectedItem == null)
			{
				MessageBox.Show("Выберите размер двигателя.", "Ошибка");
			}
			else if (EngineTechComboBox.SelectedItem == null)
			{
				MessageBox.Show("Выберите технологию двигателя.", "Ошибка");
			}
			else if (EnginesListBox.SelectedItem == null || EngineSizeComboBox.SelectedItem == null || EngineTechComboBox.SelectedItem == null)
			{
				MessageBox.Show("Выберите двигатель, его размер и уровень технологии перед добавлением.", "Ошибка");
			}
			else if (CanAddEngine())
			{
				string text = EnginesListBox.SelectedItem.ToString();
				string text2 = EngineSizeComboBox.SelectedItem.ToString();
				string text3 = EngineTechComboBox.SelectedItem.ToString();
				string item = text + " (" + text2 + ", " + text3 + ")";
				PickedEnginesListBox.Items.Add(item);
				if (text.Contains("Маневровый"))
				{
					RecalculateAgilityFromEngines();
				}
				else
				{
					UpdateAgilityLabel();
				}
				UpdateSpeedLabels();
				UpdateCostLabel();
			}
		}

		private void RemoveEngineButton_Click(object sender, EventArgs e)
		{
			if (PickedEnginesListBox.SelectedItem == null)
			{
				MessageBox.Show("Выберите двигатель для удаления.", "Ошибка");
				return;
			}
			string text = PickedEnginesListBox.SelectedItem.ToString();
			PickedEnginesListBox.Items.Remove(text);
			if (text.Contains("Маневровый"))
			{
				RecalculateAgilityFromEngines();
			}
			else
			{
				UpdateAgilityLabel();
			}
			UpdateSpeedLabels();
			UpdateCostLabel();
		}

		private void RecalculateAgilityFromEngines()
		{
			_maneuverEngineLevel = 0;
			foreach (string item in PickedEnginesListBox.Items)
			{
				if (item.Contains("Маневровый"))
				{
					if (item.Contains("1 уровень"))
					{
						_maneuverEngineLevel = Math.Max(_maneuverEngineLevel, 1);
					}
					else if (item.Contains("2 уровень"))
					{
						_maneuverEngineLevel = Math.Max(_maneuverEngineLevel, 2);
					}
					else if (item.Contains("3 уровень"))
					{
						_maneuverEngineLevel = Math.Max(_maneuverEngineLevel, 3);
					}
					else if (item.Contains("4 уровень"))
					{
						_maneuverEngineLevel = Math.Max(_maneuverEngineLevel, 4);
					}
				}
			}
			UpdateAgilityLabel(_maneuverEngineLevel);
		}

		private void UpdateWeaponLimits()
		{
			string text = SizeComboBox.SelectedItem?.ToString() ?? "";
			string text2 = ClassComboBox.SelectedItem?.ToString() ?? "";
			if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2))
			{
				FrontWeapCapLabel.Text = "Курсовые орудия: 0/0";
				TurretWeapCapLabel.Text = "Турельные орудия: 0/0";
				return;
			}
			try
			{
				int num = ShipCalculator.CalculateWeaponLimit(text, "Front", isForward: true, DictioneryStorage.ForwardWeaponsBySize, DictioneryStorage.TurretsBySize, DictioneryStorage.TurretWeapMod, text2);
				int num2 = ShipCalculator.CalculateWeaponLimit(text, "Turret", isForward: false, DictioneryStorage.ForwardWeaponsBySize, DictioneryStorage.TurretsBySize, DictioneryStorage.TurretWeapMod, text2);
				int num3 = ShipCalculator.CalculateWeaponSlotUsage(FrontWeapListBox, DictioneryStorage.EnergyCostAndSizeByItem);
				int num4 = ShipCalculator.CalculateWeaponSlotUsage(TurretWeapListBox, DictioneryStorage.EnergyCostAndSizeByItem);
				FrontWeapCapLabel.Text = $"Курсовые орудия: {num3}/{num}";
				TurretWeapCapLabel.Text = $"Турельные орудия: {num4}/{num2}";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка при обновлении лимитов: " + ex.Message, "Ошибка");
			}
		}

		private void AddWeaponToList(string weaponName, ListBox listBox, TextBox quantityBox, string weaponType, bool isForward)
		{
			string text = SizeComboBox.SelectedItem?.ToString() ?? "";
			string shipClass = ClassComboBox.SelectedItem?.ToString() ?? "";
			if (!int.TryParse(quantityBox.Text, out var result) || result <= 0)
			{
				MessageBox.Show("Введите корректное количество.", "Ошибка");
				return;
			}
			if (!ShipCalculator.CanAddWeapon(weaponName, text, weaponType, isForward, DictioneryStorage.Weapons))
			{
				MessageBox.Show("Орудие '" + weaponName + "' нельзя установить на текущий корабль размера " + text + ".", "Ошибка");
				return;
			}
			int num = ShipCalculator.CalculateWeaponLimit(text, weaponType, isForward, DictioneryStorage.ForwardWeaponsBySize, DictioneryStorage.TurretsBySize, DictioneryStorage.TurretWeapMod, shipClass);
			int num2 = ShipCalculator.CalculateWeaponSlotUsage(listBox, DictioneryStorage.EnergyCostAndSizeByItem);
			int num3 = ((!DictioneryStorage.EnergyCostAndSizeByItem.ContainsKey(weaponName)) ? 1 : DictioneryStorage.EnergyCostAndSizeByItem[weaponName].CellSize);
			if (num2 + num3 * result > num)
			{
				MessageBox.Show($"Превышен лимит {weaponType.ToLower()} орудий. Текущий лимит слотов: {num}.", "Ошибка");
				return;
			}
			for (int i = 0; i < result; i++)
			{
				listBox.Items.Add(weaponName);
			}
			UpdateWeaponLimits();
		}

		private void AddFrontWeapButton_Click(object sender, EventArgs e)
		{
			if (WeaponsListBox.SelectedItem == null)
			{
				MessageBox.Show("Выберите оружие для добавления.", "Ошибка");
				return;
			}
			string weaponName = WeaponsListBox.SelectedItem.ToString();
			AddWeaponToList(weaponName, FrontWeapListBox, FrontWeapNumTextBox, "Курсовые", isForward: true);
			UpdateCostLabel();
			UpdateWeaponLimits();
		}

		private void AddTurretWeapButton_Click(object sender, EventArgs e)
		{
			if (WeaponsListBox.SelectedItem == null)
			{
				MessageBox.Show("Выберите оружие для добавления.", "Ошибка");
				return;
			}
			string weaponName = WeaponsListBox.SelectedItem.ToString();
			AddWeaponToList(weaponName, TurretWeapListBox, TurretWeapNumTextBox, "Турельные", isForward: false);
			UpdateCostLabel();
			UpdateWeaponLimits();
		}

		private void RemoveWeapons(ListBox listBox, TextBox quantityBox)
		{
			if (!int.TryParse(quantityBox.Text, out var result) || result <= 0)
			{
				MessageBox.Show("Введите корректное количество для удаления.", "Ошибка");
				return;
			}
			while (result > 0 && listBox.Items.Count > 0)
			{
				listBox.Items.RemoveAt(listBox.Items.Count - 1);
				result--;
			}
			UpdateWeaponLimits();
			UpdateCostLabel();
		}

		private void RemoveFrontWeapButton_Click(object sender, EventArgs e)
		{
			RemoveWeapons(FrontWeapListBox, FrontWeapNumTextBox);
			UpdateCostLabel();
			UpdateWeaponLimits();
		}

		private void RemoveTurretWeapButton_Click(object sender, EventArgs e)
		{
			RemoveWeapons(TurretWeapListBox, TurretWeapNumTextBox);
			UpdateCostLabel();
			UpdateWeaponLimits();
		}

		private void RemoveAllFrontWeapButton_Click(object sender, EventArgs e)
		{
			FrontWeapListBox.Items.Clear();
			UpdateWeaponLimits();
			UpdateCostLabel();
		}

		private void RemoveAllTurretWeapButton_Click(object sender, EventArgs e)
		{
			TurretWeapListBox.Items.Clear();
			UpdateWeaponLimits();
			UpdateCostLabel();
		}

		private void FrontWeapListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateReactorLabel();
			UpdateWeaponLimits();
			UpdateCostLabel();
		}

		private void TurretWeapListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateReactorLabel();
			UpdateWeaponLimits();
			UpdateCostLabel();
		}

		private void UpdateReactorLabel()
		{
			string text = SizeComboBox.SelectedItem?.ToString() ?? "";
			string text2 = ClassComboBox.SelectedItem?.ToString() ?? "";
			if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2))
			{
				ReactorLabel.Text = "Реактор: -";
				return;
			}
			try
			{
				int num = ShipCalculator.CalculateReactorOutput(text, text2, QualityComboBox.SelectedItem?.ToString() ?? "", DictioneryStorage.ReactorBySize, DictioneryStorage.ReactorMod, DictioneryStorage.BuildQuality);
				int num2 = ShipCalculator.CalculateEnergyConsumption(AddedCivilSlotListBox, AddedSpecialSlotListBox, FrontWeapListBox, TurretWeapListBox, text2, DictioneryStorage.EnergyCostAndSizeByItem, DictioneryStorage.FreeSlotsByClass);
				ReactorLabel.Text = $"Реактор: {num}/{num2}";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка при обновлении ReactorLabel: " + ex.Message, "Ошибка");
				ReactorLabel.Text = "Реактор: ошибка";
			}
		}

		private void UpdateSpeedLabels()
		{
			string text = SizeComboBox.SelectedItem?.ToString() ?? "";
			string text2 = ClassComboBox.SelectedItem?.ToString() ?? "";
			if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2))
			{
				BaseSpeedLabel.Text = "Базовая скорость: N/A";
				SpaceSpeedLabel.Text = "Космическая скорость: N/A";
				AtmoSpeedLabel.Text = "Атмосферная скорость: N/A";
				SingleUseSpeedLabel.Text = "Одноразовая скорость: N/A";
				return;
			}
			try
			{
				BaseSpeedLabel.Text = "Базовая скорость: " + ShipCalculator.CalculateSpeed("Маневровый", text, text2, PickedEnginesListBox, DictioneryStorage.EngineLvl, DictioneryStorage.EngineSizeModifiers, DictioneryStorage.SpeedMod, DictioneryStorage.EngineTypeModifiers);
				SpaceSpeedLabel.Text = "Космическая скорость: " + ShipCalculator.CalculateSpeed("Космический", text, text2, PickedEnginesListBox, DictioneryStorage.EngineLvl, DictioneryStorage.EngineSizeModifiers, DictioneryStorage.SpeedMod, DictioneryStorage.EngineTypeModifiers);
				AtmoSpeedLabel.Text = "Атмосферная скорость: " + ShipCalculator.CalculateSpeed("Атмосферный", text, text2, PickedEnginesListBox, DictioneryStorage.EngineLvl, DictioneryStorage.EngineSizeModifiers, DictioneryStorage.SpeedMod, DictioneryStorage.EngineTypeModifiers);
				SingleUseSpeedLabel.Text = "Одноразовая скорость: " + ShipCalculator.CalculateSpeed("Одноразовый", text, text2, PickedEnginesListBox, DictioneryStorage.EngineLvl, DictioneryStorage.EngineSizeModifiers, DictioneryStorage.SpeedMod, DictioneryStorage.EngineTypeModifiers);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка при обновлении скоростей: " + ex.Message, "Ошибка");
			}
		}

		private void PickedEnginesListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateSpeedLabels();
			UpdateCostLabel();
		}

		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "https://docs.google.com/document/d/15gLXy4TyzLqEJH13ewRM5ywD948ohAmKd3_pYbozfP0/edit?usp=sharing",
				UseShellExecute = true
			});
		}

		private bool CanAddEngine()
		{
			if (PickedEnginesListBox.Items.Count >= 4)
			{
				MessageBox.Show("Вы не можете добавить более 4 двигателей.", "Ошибка");
				return false;
			}
			return true;
		}

		private void UpdateStorageAndHangarLabels()
		{
			string text = SizeComboBox.SelectedItem?.ToString() ?? "";
			string text2 = ClassComboBox.SelectedItem?.ToString() ?? "";
			if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2))
			{
				CargoCapLabel.Text = "Ёмкость общего склада: N/A";
				FuelCapLabel.Text = "Ёмкость склада топлива: N/A";
				MedCapLabel.Text = "Ёмкость склада медицины: N/A";
				AmmoCapLabel.Text = "Ёмкость склада боеприпасов: N/A";
				HangarCapLabel.Text = "Ангар: N/A";
				ChelnokHangarCapLabel.Text = "Ангар челноков: N/A";
				return;
			}
			try
			{
				CargoCapLabel.Text = "Ёмкость общего склада: " + ShipCalculator.CalculateStorageCapacity("Склад общий", text, text2, AddedCivilSlotListBox, DictioneryStorage.StorageCapacitiesByType, DictioneryStorage.ClassSpecificModifiers) + " л.";
				FuelCapLabel.Text = "Ёмкость склада топлива: " + ShipCalculator.CalculateStorageCapacity("Склад топлива", text, text2, AddedCivilSlotListBox, DictioneryStorage.StorageCapacitiesByType, DictioneryStorage.ClassSpecificModifiers) + " л.";
				MedCapLabel.Text = "Ёмкость склада медицины: " + ShipCalculator.CalculateStorageCapacity("Склад медицины", text, text2, AddedCivilSlotListBox, DictioneryStorage.StorageCapacitiesByType, DictioneryStorage.ClassSpecificModifiers) + " л.";
				AmmoCapLabel.Text = "Ёмкость склада боеприпасов: " + ShipCalculator.CalculateStorageCapacity("Склад боеприпасов", text, text2, AddedCivilSlotListBox, DictioneryStorage.StorageCapacitiesByType, DictioneryStorage.ClassSpecificModifiers) + " л.";
				HangarCapLabel.Text = "Ангар: " + ShipCalculator.CalculateHangarCapacity("Ангар общего назначения", text2, AddedCivilSlotListBox, DictioneryStorage.HangarCapacitiesByType, DictioneryStorage.ClassSpecificModifiers, DictioneryStorage.FreeSlotsByClass) + " мест.";
				ChelnokHangarCapLabel.Text = "Ангар челноков: " + ShipCalculator.CalculateHangarCapacity("Ангар для челноков", text2, AddedCivilSlotListBox, DictioneryStorage.HangarCapacitiesByType, DictioneryStorage.ClassSpecificModifiers, DictioneryStorage.FreeSlotsByClass) + " мест.";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка при обновлении меток складов и ангаров: " + ex.Message, "Ошибка");
			}
		}

		private List<string> GetCheckedItems(CheckedListBox checkedListBox)
		{
			List<string> list = new List<string>();
			foreach (object checkedItem in checkedListBox.CheckedItems)
			{
				list.Add(checkedItem.ToString());
			}
			return list;
		}

		private Dictionary<string, int> GetSensorCostsForSize(string shipSize)
		{
			if (DictioneryStorage.SensorCostsBySize.ContainsKey(shipSize))
			{
				return DictioneryStorage.SensorCostsBySize[shipSize];
			}
			return new Dictionary<string, int>();
		}

		private void UpdateCostLabel()
		{
			string shipSize = SizeComboBox.SelectedItem?.ToString() ?? "";
			string shipClass = ClassComboBox.SelectedItem?.ToString() ?? "";
			string buildQuality = QualityComboBox.SelectedItem?.ToString() ?? "";
			string priceAddModifier = PriceAddComboBox.SelectedItem?.ToString() ?? "";
			double armorThickness = ((ArmorThiccTextBox.Text != "") ? Math.Max(0.0, Math.Min(500.0, Convert.ToDouble(ArmorThiccTextBox.Text))) : 100.0);
			bool @checked = BoriCheckBox.Checked;
			bool checked2 = StalCheckBox.Checked;
			bool checked3 = HassCheckBox.Checked;
			try
			{
				List<string> checkedItems = GetCheckedItems(SensorsCheckedListBox);
				Dictionary<string, int> sensorCostsForSize = GetSensorCostsForSize(shipSize);
				int num = ShipCalculator.CalculateCost(shipSize, shipClass, buildQuality, PickedEnginesListBox, checkedItems, FrontWeapListBox, TurretWeapListBox, AddedCivilSlotListBox, AddedSpecialSlotListBox, priceAddModifier, armorThickness, @checked, checked2, checked3, DictioneryStorage.ShipSizeCosts, DictioneryStorage.ShipClassCostModifiers, DictioneryStorage.BuildQuality, sensorCostsForSize, DictioneryStorage.Weapons, DictioneryStorage.CivilianCellCosts, DictioneryStorage.SpecialCellCosts, DictioneryStorage.PriceAdd);
				CostLabel.Text = $"Стоимость: {num:N0} АР";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка при расчёте стоимости: " + ex.Message, "Ошибка");
				CostLabel.Text = "Стоимость: ошибка";
			}
		}

		private void SensorsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateCostLabel();
		}

		private void SensorsCheckedListBox_SelectedValueChanged(object sender, EventArgs e)
		{
			UpdateCostLabel();
		}

		private void PriceAddComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateCostLabel();
		}

		private void PriceAddComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			UpdateCostLabel();
		}

		private void ClearAllRelevantLists()
		{
			FrontWeapListBox.Items.Clear();
			TurretWeapListBox.Items.Clear();
			AddedCivilSlotListBox.Items.Clear();
			AddedSpecialSlotListBox.Items.Clear();
		}

		private void changeLogsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new Change_log().Show();
		}

		private void описаниеМодулейToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new DescAndCostWindow().Show();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = "Текстовый файл (*.txt)|*.txt|JSON файл (*.json)|*.json";
				saveFileDialog.Title = "Сохранить конфигурацию";
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					string fileName = saveFileDialog.FileName;
					if (fileName.EndsWith(".txt"))
					{
						SaveAsText(fileName);
					}
					else if (fileName.EndsWith(".json"))
					{
						SaveAsJson(fileName);
					}
				}
			}
		}

		private void SaveAsText(string filePath)
		{
			try
			{
				string contents = GenerateTextContent();
				File.WriteAllText(filePath, contents);
				MessageBox.Show("Конфигурация успешно сохранена!", "Успех");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка при сохранении файла: " + ex.Message, "Ошибка");
			}
		}

		private void SaveAsJson(string filePath)
		{
			try
			{
				string contents = JsonConvert.SerializeObject((object)new
				{
					ShipName = NameTextBox.Text,
					Size = SizeComboBox.SelectedItem,
					Class = ClassComboBox.SelectedItem,
					Quality = QualityComboBox.SelectedItem,
					Hull = HullLabel.Text,
					Armor = ArmorLabel.Text,
					Shields = ShieldLabel.Text,
					Agility = AgilityLabel.Text,
					Reactor = ReactorLabel.Text,
					ControlUnit = ControlUnitComboBox.SelectedItem,
					Crew = CrewLabel.Text,
					Sensors = SensorsCheckedListBox.CheckedItems.Cast<string>().ToList(),
					CivilSlots = AddedCivilSlotListBox.Items.Cast<string>().ToList(),
					SpecialSlots = AddedSpecialSlotListBox.Items.Cast<string>().ToList(),
					Engines = PickedEnginesListBox.Items.Cast<string>().ToList(),
					CargoCapacity = CargoCapLabel.Text,
					FuelCapacity = FuelCapLabel.Text,
					AmmoCapacity = AmmoCapLabel.Text,
					MedCapacity = MedCapLabel.Text,
					HangarCapacity = HangarCapLabel.Text,
					ShuttleHangarCapacity = ChelnokHangarCapLabel.Text,
					FrontWeapons = FrontWeapListBox.Items.Cast<string>().ToList(),
					TurretWeapons = TurretWeapListBox.Items.Cast<string>().ToList(),
					Speed = new
					{
						Base = BaseSpeedLabel.Text,
						Space = SpaceSpeedLabel.Text,
						Atmospheric = AtmoSpeedLabel.Text,
						SingleUse = SingleUseSpeedLabel.Text
					},
					ArmorThickness = ArmorThiccTextBox.Text,
					Modifiers = new
					{
						Bori = BoriCheckBox.Checked,
						Stalinium = StalCheckBox.Checked,
						Hassatium = HassCheckBox.Checked
					},
					PriceMultiplier = PriceAddComboBox.SelectedItem,
					TotalCost = CostLabel.Text,
					Inventory = InventoryTextBox.Text.Cast<string>().ToList()
				}, (Formatting)1);
				File.WriteAllText(filePath, contents);
				MessageBox.Show("Конфигурация успешно сохранена!", "Успех");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка при сохранении файла: " + ex.Message, "Ошибка");
			}
		}

		private string GenerateTextContent()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("Название: " + NameTextBox.Text);
			stringBuilder.AppendLine($"Размер: {SizeComboBox.SelectedItem}");
			stringBuilder.AppendLine($"Класс: {ClassComboBox.SelectedItem}");
			stringBuilder.AppendLine($"Качество сборки корабля - {QualityComboBox.SelectedItem}");
			stringBuilder.AppendLine(new string('=', 100));
			stringBuilder.AppendLine("Характеристики:");
			stringBuilder.AppendLine();
			stringBuilder.AppendLine(HullLabel.Text ?? "");
			stringBuilder.AppendLine(ArmorLabel.Text ?? "");
			stringBuilder.AppendLine(ShieldLabel.Text ?? "");
			stringBuilder.AppendLine(AgilityLabel.Text ?? "");
			stringBuilder.AppendLine(ReactorLabel.Text ?? "");
			stringBuilder.AppendLine($"Метод управления - {ControlUnitComboBox.SelectedItem}");
			stringBuilder.AppendLine(CrewLabel.Text ?? "");
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("Сенсоры - " + string.Join(", ", SensorsCheckedListBox.CheckedItems.Cast<string>()));
			stringBuilder.AppendLine(new string('=', 100));
			stringBuilder.AppendLine("Описание класса корабля: " + DescTextBox.Text);
			stringBuilder.AppendLine(new string('=', 100));
			stringBuilder.AppendLine("Гражданские ячейки:");
			foreach (object item in AddedCivilSlotListBox.Items)
			{
				stringBuilder.AppendLine($"- {item}");
			}
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("Особые ячейки:");
			foreach (object item2 in AddedSpecialSlotListBox.Items)
			{
				stringBuilder.AppendLine($"- {item2}");
			}
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("Двигатели:");
			foreach (object item3 in PickedEnginesListBox.Items)
			{
				stringBuilder.AppendLine($"- {item3}");
			}
			stringBuilder.AppendLine(new string('=', 100));
			stringBuilder.AppendLine("Внутренние объёмы складов и ангаров:");
			stringBuilder.AppendLine("Объём грузового отсека: " + CargoCapLabel.Text);
			stringBuilder.AppendLine("Объём топливного бака: " + FuelCapLabel.Text);
			stringBuilder.AppendLine("Объём складов вооружения: " + AmmoCapLabel.Text);
			stringBuilder.AppendLine("Объём складов медицины: " + MedCapLabel.Text);
			stringBuilder.AppendLine("Ёмкость ангара: " + HangarCapLabel.Text);
			stringBuilder.AppendLine("Ёмкость ангара челноков: " + ChelnokHangarCapLabel.Text);
			stringBuilder.AppendLine(new string('=', 100));
			stringBuilder.AppendLine("Курсовое вооружение:");
			foreach (object item4 in FrontWeapListBox.Items)
			{
				stringBuilder.AppendLine($"- {item4}");
			}
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("Турельное вооружение:");
			foreach (object item5 in TurretWeapListBox.Items)
			{
				stringBuilder.AppendLine($"- {item5}");
			}
			stringBuilder.AppendLine(new string('=', 100));
			stringBuilder.AppendLine("Скорости разных двигателей:");
			stringBuilder.AppendLine("Маневровые двигатели: " + BaseSpeedLabel.Text);
			stringBuilder.AppendLine("Космические двигатели: " + SpaceSpeedLabel.Text);
			stringBuilder.AppendLine("Атмосферные двигатели: " + AtmoSpeedLabel.Text);
			stringBuilder.AppendLine("Одноразовые двигатели: " + SingleUseSpeedLabel.Text);
			stringBuilder.AppendLine(new string('=', 100));
			stringBuilder.AppendLine("Дополнительные особенности:");
			stringBuilder.AppendLine("Толщина брони: " + ArmorThiccTextBox.Text + "%");
			stringBuilder.AppendLine("Корпус из Бориформия - " + (BoriCheckBox.Checked ? "Да" : "Нет"));
			stringBuilder.AppendLine("Броня из Сталиниума - " + (StalCheckBox.Checked ? "Да" : "Нет"));
			stringBuilder.AppendLine("Щиты из Хассатия-Б - " + (HassCheckBox.Checked ? "Да" : "Нет"));
			stringBuilder.AppendLine($"Наценка за покупку: {PriceAddComboBox.SelectedItem}");
			stringBuilder.AppendLine(new string('=', 100));
			stringBuilder.AppendLine("Итоговая стоимость: " + CostLabel.Text + " АР");
			stringBuilder.AppendLine(new string('=', 100));
			stringBuilder.AppendLine("Инвентарь:");
			string text = InventoryTextBox.Text;
			foreach (char c in text)
			{
				stringBuilder.AppendLine($"- {c}");
			}
			return stringBuilder.ToString();
		}

		private void LoadConfigurationButton_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Текстовый файл (*.txt)|*.txt|JSON файл (*.json)|*.json";
				openFileDialog.Title = "Загрузить конфигурацию";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					string fileName = openFileDialog.FileName;
					if (fileName.EndsWith(".txt"))
					{
						LoadFromText(fileName);
					}
					else if (fileName.EndsWith(".json"))
					{
						LoadFromJson(fileName);
					}
				}
			}
		}

		private void LoadFromText(string filePath)
		{
			try
			{
				string[] lines = File.ReadAllLines(filePath);
				NameTextBox.Text = ExtractValue(lines, "Название:");
				SizeComboBox.SelectedItem = ExtractValue(lines, "Размер:");
				ClassComboBox.SelectedItem = ExtractValue(lines, "Класс:");
				QualityComboBox.SelectedItem = ExtractValue(lines, "Качество сборки корабля -");
				HullLabel.Text = ExtractValue(lines, "Корпус -");
				ArmorLabel.Text = ExtractValue(lines, "Броня -");
				ShieldLabel.Text = ExtractValue(lines, "Щиты -");
				AgilityLabel.Text = ExtractValue(lines, "Манёвренность -");
				ReactorLabel.Text = ExtractValue(lines, "Общее потребление энергии -");
				ControlUnitComboBox.SelectedItem = ExtractValue(lines, "Метод управления -");
				CrewLabel.Text = ExtractValue(lines, "Экипаж от:");
				string obj = ExtractValue(lines, "Сенсоры -");
				SensorsCheckedListBox.Items.Clear();
				string[] array = obj.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
				foreach (string text in array)
				{
					SensorsCheckedListBox.Items.Add(text.Trim(), isChecked: true);
				}
				string startMarker = "Описание класса корабля:";
				string endMarker = "======================================================================================================";
				DescTextBox.Text = ExtractSection(lines, startMarker, endMarker);
				AddedCivilSlotListBox.Items.Clear();
				string section = ExtractSection(lines, "Гражданские ячейки", "Особые ячейки");
				foreach (string item in ExtractListItems(section))
				{
					AddedCivilSlotListBox.Items.Add(item);
				}
				AddedSpecialSlotListBox.Items.Clear();
				string section2 = ExtractSection(lines, "Особые ячейки", "Двигатели:");
				foreach (string item2 in ExtractListItems(section2))
				{
					AddedSpecialSlotListBox.Items.Add(item2);
				}
				PickedEnginesListBox.Items.Clear();
				string section3 = ExtractSection(lines, "Двигатели:", "Внутренние объёмы складов и ангаров:");
				foreach (string item3 in ExtractListItems(section3))
				{
					PickedEnginesListBox.Items.Add(item3);
				}
				CargoCapLabel.Text = ExtractValue(lines, "Объём грузового отсека:");
				FuelCapLabel.Text = ExtractValue(lines, "Объём топливного бака:");
				AmmoCapLabel.Text = ExtractValue(lines, "Объём складов вооружения:");
				MedCapLabel.Text = ExtractValue(lines, "Объём складов медицины:");
				HangarCapLabel.Text = ExtractValue(lines, "Ёмкость ангара:");
				ChelnokHangarCapLabel.Text = ExtractValue(lines, "Ёмкость ангара челноков:");
				FrontWeapListBox.Items.Clear();
				string section4 = ExtractSection(lines, "Курсовое вооружение", "Турельное вооружение");
				foreach (string item4 in ExtractListItems(section4))
				{
					FrontWeapListBox.Items.Add(item4);
				}
				TurretWeapListBox.Items.Clear();
				string section5 = ExtractSection(lines, "Турельное вооружение", "Скорости разных двигателей:");
				foreach (string item5 in ExtractListItems(section5))
				{
					TurretWeapListBox.Items.Add(item5);
				}
				ArmorThiccTextBox.Text = ExtractValue(lines, "Толщина брони:");
				BoriCheckBox.Checked = ExtractValue(lines, "Корпус из Бориформия -") == "Да";
				StalCheckBox.Checked = ExtractValue(lines, "Броня из Сталиниума -") == "Да";
				HassCheckBox.Checked = ExtractValue(lines, "Щиты из Хассатия-Б -") == "Да";
				PriceAddComboBox.SelectedItem = ExtractValue(lines, "Наценка за покупку:");
				CostLabel.Text = ExtractValue(lines, "Итоговая стоимость:");
				MessageBox.Show("Конфигурация успешно загружена из .txt!", "Успех");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка при загрузке .txt файла: " + ex.Message, "Ошибка");
			}
		}

		private string ExtractValue(string[] lines, string prefix)
		{
			return lines.FirstOrDefault((string l) => l.StartsWith(prefix))?.Substring(prefix.Length).Trim() ?? string.Empty;
		}

		private string ExtractSection(string[] lines, string startMarker, string endMarker)
		{
			int num = Array.IndexOf(lines, startMarker) + 1;
			int num2 = Array.IndexOf(lines, endMarker);
			if (num == 0 || num2 == -1 || num >= num2)
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = num; i < num2; i++)
			{
				stringBuilder.AppendLine(lines[i]);
			}
			return stringBuilder.ToString().Trim();
		}

		private List<string> ExtractListItems(string section)
		{
			return (from line in section.Split(new char[2] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
				where line.StartsWith("-")
				select line.Substring(1).Trim()).ToList();
		}

		private void LoadFromJson(string filePath)
		{
			try
			{
				dynamic val = JsonConvert.DeserializeObject<object>(File.ReadAllText(filePath));
				NameTextBox.Text = (string)val.ShipName;
				SizeComboBox.SelectedItem = (string)val.Size;
				ClassComboBox.SelectedItem = (string)val.Class;
				QualityComboBox.SelectedItem = (string)val.Quality;
				HullLabel.Text = (string)val.Hull;
				ArmorLabel.Text = (string)val.Armor;
				ShieldLabel.Text = (string)val.Shields;
				AgilityLabel.Text = (string)val.Agility;
				ReactorLabel.Text = (string)val.Reactor;
				ControlUnitComboBox.SelectedItem = (string)val.ControlUnit;
				CrewLabel.Text = (string)val.Crew;
				SensorsCheckedListBox.Items.Clear();
				foreach (dynamic item in val.Sensors)
				{
					SensorsCheckedListBox.Items.Add((string)item, isChecked: true);
				}
				AddedCivilSlotListBox.Items.Clear();
				foreach (dynamic item2 in val.CivilSlots)
				{
					AddedCivilSlotListBox.Items.Add((string)item2);
				}
				AddedSpecialSlotListBox.Items.Clear();
				foreach (dynamic item3 in val.SpecialSlots)
				{
					AddedSpecialSlotListBox.Items.Add((string)item3);
				}
				PickedEnginesListBox.Items.Clear();
				foreach (dynamic item4 in val.Engines)
				{
					PickedEnginesListBox.Items.Add((string)item4);
				}
				CargoCapLabel.Text = (string)val.CargoCapacity;
				FuelCapLabel.Text = (string)val.FuelCapacity;
				AmmoCapLabel.Text = (string)val.AmmoCapacity;
				MedCapLabel.Text = (string)val.MedCapacity;
				HangarCapLabel.Text = (string)val.HangarCapacity;
				ChelnokHangarCapLabel.Text = (string)val.ShuttleHangarCapacity;
				FrontWeapListBox.Items.Clear();
				foreach (dynamic item5 in val.FrontWeapons)
				{
					FrontWeapListBox.Items.Add((string)item5);
				}
				TurretWeapListBox.Items.Clear();
				foreach (dynamic item6 in val.TurretWeapons)
				{
					TurretWeapListBox.Items.Add((string)item6);
				}
				BaseSpeedLabel.Text = (string)val.Speed.Base;
				SpaceSpeedLabel.Text = (string)val.Speed.Space;
				AtmoSpeedLabel.Text = (string)val.Speed.Atmospheric;
				SingleUseSpeedLabel.Text = (string)val.Speed.SingleUse;
				ArmorThiccTextBox.Text = (string)val.ArmorThickness;
				BoriCheckBox.Checked = (bool)val.Modifiers.Bori;
				StalCheckBox.Checked = (bool)val.Modifiers.Stalinium;
				HassCheckBox.Checked = (bool)val.Modifiers.Hassatium;
				PriceAddComboBox.SelectedItem = (string)val.PriceMultiplier;
				CostLabel.Text = (string)val.TotalCost;
				InventoryTextBox.Clear();
				InventoryTextBox.Text = string.Join(Environment.NewLine, val.Inventory.ToObject<List<string>>());
				MessageBox.Show("Конфигурация успешно загружена из .json!", "Успех");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка при загрузке .json файла: " + ex.Message, "Ошибка");
			}
		}

		private void InitializeComponent()
		{
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.SecPropGroupBox = new System.Windows.Forms.GroupBox();
            this.MedCapLabel = new System.Windows.Forms.Label();
            this.ChelnokHangarCapLabel = new System.Windows.Forms.Label();
            this.AmmoCapLabel = new System.Windows.Forms.Label();
            this.FuelCapLabel = new System.Windows.Forms.Label();
            this.HangarCapLabel = new System.Windows.Forms.Label();
            this.CargoCapLabel = new System.Windows.Forms.Label();
            this.SpeedsGroupBox = new System.Windows.Forms.GroupBox();
            this.SpaceSpeedLabel = new System.Windows.Forms.Label();
            this.SingleUseSpeedLabel = new System.Windows.Forms.Label();
            this.BaseSpeedLabel = new System.Windows.Forms.Label();
            this.AtmoSpeedLabel = new System.Windows.Forms.Label();
            this.DescTextBox = new System.Windows.Forms.TextBox();
            this.DescLabel = new System.Windows.Forms.Label();
            this.InventoryTextBox = new System.Windows.Forms.TextBox();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.CurrentWeapGroupBox = new System.Windows.Forms.GroupBox();
            this.TurretWeapCapLabel = new System.Windows.Forms.Label();
            this.FrontWeapCapLabel = new System.Windows.Forms.Label();
            this.RemoveAllTurretWeapButton = new System.Windows.Forms.Button();
            this.RemoveAllFrontWeapButton = new System.Windows.Forms.Button();
            this.TurretWeapListBox = new System.Windows.Forms.ListBox();
            this.RemoveTurretWeapButton = new System.Windows.Forms.Button();
            this.FrontWeapListBox = new System.Windows.Forms.ListBox();
            this.RemoveFrontWeapButton = new System.Windows.Forms.Button();
            this.TurretWeapNumTextBox = new System.Windows.Forms.TextBox();
            this.FrontWeapNumTextBox = new System.Windows.Forms.TextBox();
            this.TurretNumLabel = new System.Windows.Forms.Label();
            this.FrontNumLabel = new System.Windows.Forms.Label();
            this.AddTurretWeapButton = new System.Windows.Forms.Button();
            this.AddFrontWeapButton = new System.Windows.Forms.Button();
            this.TurretWeapLabel = new System.Windows.Forms.Label();
            this.FrontWeapLabel = new System.Windows.Forms.Label();
            this.WeaponsLabel = new System.Windows.Forms.Label();
            this.WeaponsListBox = new System.Windows.Forms.ListBox();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.SpecialSlotsGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoveAllSpecialSlotButton = new System.Windows.Forms.Button();
            this.AddedSpecialSlotsLabel = new System.Windows.Forms.Label();
            this.SpecialRemoveTextBox = new System.Windows.Forms.TextBox();
            this.SpecialRemoveLabel = new System.Windows.Forms.Label();
            this.RemoveSpecialSlotButton = new System.Windows.Forms.Button();
            this.SpecialAddTextBox = new System.Windows.Forms.TextBox();
            this.AddedSpecialSlotListBox = new System.Windows.Forms.ListBox();
            this.SpecialAddLabel = new System.Windows.Forms.Label();
            this.AddSpecialSlotButton = new System.Windows.Forms.Button();
            this.SpecialSlotListBox = new System.Windows.Forms.ListBox();
            this.SpecialSlotsLabel = new System.Windows.Forms.Label();
            this.CivilSlotsGroupBox = new System.Windows.Forms.GroupBox();
            this.RemoveAllCivilSlotButton = new System.Windows.Forms.Button();
            this.AddedCivilSlotsLabel = new System.Windows.Forms.Label();
            this.CivilRemoveTextBox = new System.Windows.Forms.TextBox();
            this.CivilRemoveLabel = new System.Windows.Forms.Label();
            this.RemoveCivilSlotButton = new System.Windows.Forms.Button();
            this.CivilAddTextBox = new System.Windows.Forms.TextBox();
            this.CivilAddLlabel = new System.Windows.Forms.Label();
            this.AddedCivilSlotListBox = new System.Windows.Forms.ListBox();
            this.AddCivilSlotButton = new System.Windows.Forms.Button();
            this.CivilSlotListBox = new System.Windows.Forms.ListBox();
            this.CivilSlotsLabel = new System.Windows.Forms.Label();
            this.MainGroupBox = new System.Windows.Forms.GroupBox();
            this.ParametrsGroupBox = new System.Windows.Forms.GroupBox();
            this.HullLabel = new System.Windows.Forms.Label();
            this.ArmorLabel = new System.Windows.Forms.Label();
            this.ShieldLabel = new System.Windows.Forms.Label();
            this.AgilityLabel = new System.Windows.Forms.Label();
            this.CrewLabel = new System.Windows.Forms.Label();
            this.ReactorLabel = new System.Windows.Forms.Label();
            this.PriceAddComboBox = new System.Windows.Forms.ComboBox();
            this.GMLabel = new System.Windows.Forms.Label();
            this.PriceAddLabel = new System.Windows.Forms.Label();
            this.AddOnGroupBox = new System.Windows.Forms.GroupBox();
            this.BoriCheckBox = new System.Windows.Forms.CheckBox();
            this.StalCheckBox = new System.Windows.Forms.CheckBox();
            this.ArmorThiccTextBox = new System.Windows.Forms.TextBox();
            this.ArmorThiccLabel = new System.Windows.Forms.Label();
            this.ControlUnitLabel = new System.Windows.Forms.Label();
            this.ControlUnitComboBox = new System.Windows.Forms.ComboBox();
            this.HassCheckBox = new System.Windows.Forms.CheckBox();
            this.EnginesGroupBox = new System.Windows.Forms.GroupBox();
            this.EngineTechComboBox = new System.Windows.Forms.ComboBox();
            this.EngineTechLvlLabel = new System.Windows.Forms.Label();
            this.EnginesTipLabel = new System.Windows.Forms.Label();
            this.RemoveEngineButton = new System.Windows.Forms.Button();
            this.AddEngineButton = new System.Windows.Forms.Button();
            this.EnginesSizeLabel = new System.Windows.Forms.Label();
            this.EngineSizeComboBox = new System.Windows.Forms.ComboBox();
            this.PickedEnginesListBox = new System.Windows.Forms.ListBox();
            this.EnginesListBox = new System.Windows.Forms.ListBox();
            this.SensorsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SensorsLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.QualityComboBox = new System.Windows.Forms.ComboBox();
            this.QualityLabel = new System.Windows.Forms.Label();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.SizeComboBox = new System.Windows.Forms.ComboBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.RulesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CostLabel = new System.Windows.Forms.Label();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.описаниеМодулейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadConfigurationButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.SecPropGroupBox.SuspendLayout();
            this.SpeedsGroupBox.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.CurrentWeapGroupBox.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.SpecialSlotsGroupBox.SuspendLayout();
            this.CivilSlotsGroupBox.SuspendLayout();
            this.MainGroupBox.SuspendLayout();
            this.ParametrsGroupBox.SuspendLayout();
            this.AddOnGroupBox.SuspendLayout();
            this.EnginesGroupBox.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Location = new System.Drawing.Point(409, 27);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(448, 436);
            this.TabControl1.TabIndex = 0;
            // 
            // TabPage3
            // 
            this.TabPage3.BackColor = System.Drawing.Color.Khaki;
            this.TabPage3.Controls.Add(this.SecPropGroupBox);
            this.TabPage3.Controls.Add(this.InventoryTextBox);
            this.TabPage3.Controls.Add(this.InventoryLabel);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(440, 410);
            this.TabPage3.TabIndex = 1;
            this.TabPage3.Text = "Описание и инвентарь";
            // 
            // SecPropGroupBox
            // 
            this.SecPropGroupBox.Controls.Add(this.MedCapLabel);
            this.SecPropGroupBox.Controls.Add(this.ChelnokHangarCapLabel);
            this.SecPropGroupBox.Controls.Add(this.AmmoCapLabel);
            this.SecPropGroupBox.Controls.Add(this.FuelCapLabel);
            this.SecPropGroupBox.Controls.Add(this.HangarCapLabel);
            this.SecPropGroupBox.Controls.Add(this.CargoCapLabel);
            this.SecPropGroupBox.Controls.Add(this.SpeedsGroupBox);
            this.SecPropGroupBox.Controls.Add(this.DescTextBox);
            this.SecPropGroupBox.Controls.Add(this.DescLabel);
            this.SecPropGroupBox.Location = new System.Drawing.Point(6, 3);
            this.SecPropGroupBox.Name = "SecPropGroupBox";
            this.SecPropGroupBox.Size = new System.Drawing.Size(431, 300);
            this.SecPropGroupBox.TabIndex = 4;
            this.SecPropGroupBox.TabStop = false;
            this.SecPropGroupBox.Text = "Описание и скорости";
            // 
            // MedCapLabel
            // 
            this.MedCapLabel.AutoSize = true;
            this.MedCapLabel.Location = new System.Drawing.Point(216, 244);
            this.MedCapLabel.Name = "MedCapLabel";
            this.MedCapLabel.Size = new System.Drawing.Size(163, 13);
            this.MedCapLabel.TabIndex = 13;
            this.MedCapLabel.Text = "Объём складов медицины: 0 л";
            // 
            // ChelnokHangarCapLabel
            // 
            this.ChelnokHangarCapLabel.AutoSize = true;
            this.ChelnokHangarCapLabel.Location = new System.Drawing.Point(216, 277);
            this.ChelnokHangarCapLabel.Name = "ChelnokHangarCapLabel";
            this.ChelnokHangarCapLabel.Size = new System.Drawing.Size(179, 13);
            this.ChelnokHangarCapLabel.TabIndex = 12;
            this.ChelnokHangarCapLabel.Text = "Ёмкость ангара челноков: 0 мест";
            // 
            // AmmoCapLabel
            // 
            this.AmmoCapLabel.AutoSize = true;
            this.AmmoCapLabel.Location = new System.Drawing.Point(216, 226);
            this.AmmoCapLabel.Name = "AmmoCapLabel";
            this.AmmoCapLabel.Size = new System.Drawing.Size(172, 13);
            this.AmmoCapLabel.TabIndex = 11;
            this.AmmoCapLabel.Text = "Объём складов вооружения: 0 л";
            // 
            // FuelCapLabel
            // 
            this.FuelCapLabel.AutoSize = true;
            this.FuelCapLabel.Location = new System.Drawing.Point(216, 208);
            this.FuelCapLabel.Name = "FuelCapLabel";
            this.FuelCapLabel.Size = new System.Drawing.Size(151, 13);
            this.FuelCapLabel.TabIndex = 10;
            this.FuelCapLabel.Text = "Объём топливного бака: 0 л";
            // 
            // HangarCapLabel
            // 
            this.HangarCapLabel.AutoSize = true;
            this.HangarCapLabel.Location = new System.Drawing.Point(216, 261);
            this.HangarCapLabel.Name = "HangarCapLabel";
            this.HangarCapLabel.Size = new System.Drawing.Size(129, 13);
            this.HangarCapLabel.TabIndex = 9;
            this.HangarCapLabel.Text = "Ёмкость ангара: 0 мест";
            // 
            // CargoCapLabel
            // 
            this.CargoCapLabel.AutoSize = true;
            this.CargoCapLabel.Location = new System.Drawing.Point(216, 191);
            this.CargoCapLabel.Name = "CargoCapLabel";
            this.CargoCapLabel.Size = new System.Drawing.Size(155, 13);
            this.CargoCapLabel.TabIndex = 8;
            this.CargoCapLabel.Text = "Объём грузового отсека: 0 л";
            // 
            // SpeedsGroupBox
            // 
            this.SpeedsGroupBox.Controls.Add(this.SpaceSpeedLabel);
            this.SpeedsGroupBox.Controls.Add(this.SingleUseSpeedLabel);
            this.SpeedsGroupBox.Controls.Add(this.BaseSpeedLabel);
            this.SpeedsGroupBox.Controls.Add(this.AtmoSpeedLabel);
            this.SpeedsGroupBox.Location = new System.Drawing.Point(6, 187);
            this.SpeedsGroupBox.Name = "SpeedsGroupBox";
            this.SpeedsGroupBox.Size = new System.Drawing.Size(206, 112);
            this.SpeedsGroupBox.TabIndex = 6;
            this.SpeedsGroupBox.TabStop = false;
            this.SpeedsGroupBox.Text = "Скорости в различных средах";
            // 
            // SpaceSpeedLabel
            // 
            this.SpaceSpeedLabel.AutoSize = true;
            this.SpaceSpeedLabel.Location = new System.Drawing.Point(6, 45);
            this.SpaceSpeedLabel.Name = "SpaceSpeedLabel";
            this.SpaceSpeedLabel.Size = new System.Drawing.Size(115, 13);
            this.SpaceSpeedLabel.TabIndex = 3;
            this.SpaceSpeedLabel.Text = "От космических: N/A";
            // 
            // SingleUseSpeedLabel
            // 
            this.SingleUseSpeedLabel.AutoSize = true;
            this.SingleUseSpeedLabel.Location = new System.Drawing.Point(6, 90);
            this.SingleUseSpeedLabel.Name = "SingleUseSpeedLabel";
            this.SingleUseSpeedLabel.Size = new System.Drawing.Size(177, 13);
            this.SingleUseSpeedLabel.TabIndex = 5;
            this.SingleUseSpeedLabel.Text = "На одноразовых двигателях: N/A";
            // 
            // BaseSpeedLabel
            // 
            this.BaseSpeedLabel.AutoSize = true;
            this.BaseSpeedLabel.Location = new System.Drawing.Point(6, 23);
            this.BaseSpeedLabel.Name = "BaseSpeedLabel";
            this.BaseSpeedLabel.Size = new System.Drawing.Size(68, 13);
            this.BaseSpeedLabel.TabIndex = 2;
            this.BaseSpeedLabel.Text = "Общая: N/A";
            // 
            // AtmoSpeedLabel
            // 
            this.AtmoSpeedLabel.AutoSize = true;
            this.AtmoSpeedLabel.Location = new System.Drawing.Point(6, 67);
            this.AtmoSpeedLabel.Name = "AtmoSpeedLabel";
            this.AtmoSpeedLabel.Size = new System.Drawing.Size(119, 13);
            this.AtmoSpeedLabel.TabIndex = 4;
            this.AtmoSpeedLabel.Text = "От атмосферных: N/A";
            // 
            // DescTextBox
            // 
            this.DescTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DescTextBox.Location = new System.Drawing.Point(6, 29);
            this.DescTextBox.Multiline = true;
            this.DescTextBox.Name = "DescTextBox";
            this.DescTextBox.ReadOnly = true;
            this.DescTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DescTextBox.Size = new System.Drawing.Size(419, 152);
            this.DescTextBox.TabIndex = 1;
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.Location = new System.Drawing.Point(131, 13);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(141, 13);
            this.DescLabel.TabIndex = 0;
            this.DescLabel.Text = "Описание класса корабля";
            // 
            // InventoryTextBox
            // 
            this.InventoryTextBox.Location = new System.Drawing.Point(12, 323);
            this.InventoryTextBox.Multiline = true;
            this.InventoryTextBox.Name = "InventoryTextBox";
            this.InventoryTextBox.Size = new System.Drawing.Size(419, 79);
            this.InventoryTextBox.TabIndex = 3;
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Location = new System.Drawing.Point(108, 306);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(228, 13);
            this.InventoryLabel.TabIndex = 2;
            this.InventoryLabel.Text = "Инвентарь корабля (заполняется вручную):";
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.MistyRose;
            this.TabPage1.Controls.Add(this.CurrentWeapGroupBox);
            this.TabPage1.Controls.Add(this.WeaponsLabel);
            this.TabPage1.Controls.Add(this.WeaponsListBox);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(440, 410);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Вооружение";
            // 
            // CurrentWeapGroupBox
            // 
            this.CurrentWeapGroupBox.Controls.Add(this.TurretWeapCapLabel);
            this.CurrentWeapGroupBox.Controls.Add(this.FrontWeapCapLabel);
            this.CurrentWeapGroupBox.Controls.Add(this.RemoveAllTurretWeapButton);
            this.CurrentWeapGroupBox.Controls.Add(this.RemoveAllFrontWeapButton);
            this.CurrentWeapGroupBox.Controls.Add(this.TurretWeapListBox);
            this.CurrentWeapGroupBox.Controls.Add(this.RemoveTurretWeapButton);
            this.CurrentWeapGroupBox.Controls.Add(this.FrontWeapListBox);
            this.CurrentWeapGroupBox.Controls.Add(this.RemoveFrontWeapButton);
            this.CurrentWeapGroupBox.Controls.Add(this.TurretWeapNumTextBox);
            this.CurrentWeapGroupBox.Controls.Add(this.FrontWeapNumTextBox);
            this.CurrentWeapGroupBox.Controls.Add(this.TurretNumLabel);
            this.CurrentWeapGroupBox.Controls.Add(this.FrontNumLabel);
            this.CurrentWeapGroupBox.Controls.Add(this.AddTurretWeapButton);
            this.CurrentWeapGroupBox.Controls.Add(this.AddFrontWeapButton);
            this.CurrentWeapGroupBox.Controls.Add(this.TurretWeapLabel);
            this.CurrentWeapGroupBox.Controls.Add(this.FrontWeapLabel);
            this.CurrentWeapGroupBox.Location = new System.Drawing.Point(150, 5);
            this.CurrentWeapGroupBox.Name = "CurrentWeapGroupBox";
            this.CurrentWeapGroupBox.Size = new System.Drawing.Size(281, 378);
            this.CurrentWeapGroupBox.TabIndex = 16;
            this.CurrentWeapGroupBox.TabStop = false;
            this.CurrentWeapGroupBox.Text = "Выбранные орудия";
            // 
            // TurretWeapCapLabel
            // 
            this.TurretWeapCapLabel.AutoSize = true;
            this.TurretWeapCapLabel.Location = new System.Drawing.Point(151, 358);
            this.TurretWeapCapLabel.Name = "TurretWeapCapLabel";
            this.TurretWeapCapLabel.Size = new System.Drawing.Size(124, 13);
            this.TurretWeapCapLabel.TabIndex = 17;
            this.TurretWeapCapLabel.Text = "Турельные орудия: 0/0";
            // 
            // FrontWeapCapLabel
            // 
            this.FrontWeapCapLabel.AutoSize = true;
            this.FrontWeapCapLabel.Location = new System.Drawing.Point(8, 358);
            this.FrontWeapCapLabel.Name = "FrontWeapCapLabel";
            this.FrontWeapCapLabel.Size = new System.Drawing.Size(118, 13);
            this.FrontWeapCapLabel.TabIndex = 16;
            this.FrontWeapCapLabel.Text = "Курсовые орудия: 0/0";
            // 
            // RemoveAllTurretWeapButton
            // 
            this.RemoveAllTurretWeapButton.Location = new System.Drawing.Point(154, 319);
            this.RemoveAllTurretWeapButton.Name = "RemoveAllTurretWeapButton";
            this.RemoveAllTurretWeapButton.Size = new System.Drawing.Size(116, 23);
            this.RemoveAllTurretWeapButton.TabIndex = 15;
            this.RemoveAllTurretWeapButton.Text = "Удалить всё";
            this.RemoveAllTurretWeapButton.UseVisualStyleBackColor = true;
            this.RemoveAllTurretWeapButton.Click += new System.EventHandler(this.RemoveAllTurretWeapButton_Click);
            // 
            // RemoveAllFrontWeapButton
            // 
            this.RemoveAllFrontWeapButton.Location = new System.Drawing.Point(11, 319);
            this.RemoveAllFrontWeapButton.Name = "RemoveAllFrontWeapButton";
            this.RemoveAllFrontWeapButton.Size = new System.Drawing.Size(116, 23);
            this.RemoveAllFrontWeapButton.TabIndex = 14;
            this.RemoveAllFrontWeapButton.Text = "Удалить всё";
            this.RemoveAllFrontWeapButton.UseVisualStyleBackColor = true;
            this.RemoveAllFrontWeapButton.Click += new System.EventHandler(this.RemoveAllFrontWeapButton_Click);
            // 
            // TurretWeapListBox
            // 
            this.TurretWeapListBox.FormattingEnabled = true;
            this.TurretWeapListBox.HorizontalScrollbar = true;
            this.TurretWeapListBox.Location = new System.Drawing.Point(142, 32);
            this.TurretWeapListBox.Name = "TurretWeapListBox";
            this.TurretWeapListBox.Size = new System.Drawing.Size(139, 199);
            this.TurretWeapListBox.TabIndex = 2;
            // 
            // RemoveTurretWeapButton
            // 
            this.RemoveTurretWeapButton.Location = new System.Drawing.Point(154, 290);
            this.RemoveTurretWeapButton.Name = "RemoveTurretWeapButton";
            this.RemoveTurretWeapButton.Size = new System.Drawing.Size(116, 23);
            this.RemoveTurretWeapButton.TabIndex = 13;
            this.RemoveTurretWeapButton.Text = "Удалить";
            this.RemoveTurretWeapButton.UseVisualStyleBackColor = true;
            this.RemoveTurretWeapButton.Click += new System.EventHandler(this.RemoveTurretWeapButton_Click);
            // 
            // FrontWeapListBox
            // 
            this.FrontWeapListBox.FormattingEnabled = true;
            this.FrontWeapListBox.HorizontalScrollbar = true;
            this.FrontWeapListBox.Location = new System.Drawing.Point(0, 32);
            this.FrontWeapListBox.Name = "FrontWeapListBox";
            this.FrontWeapListBox.Size = new System.Drawing.Size(139, 199);
            this.FrontWeapListBox.TabIndex = 1;
            // 
            // RemoveFrontWeapButton
            // 
            this.RemoveFrontWeapButton.Location = new System.Drawing.Point(11, 290);
            this.RemoveFrontWeapButton.Name = "RemoveFrontWeapButton";
            this.RemoveFrontWeapButton.Size = new System.Drawing.Size(116, 23);
            this.RemoveFrontWeapButton.TabIndex = 12;
            this.RemoveFrontWeapButton.Text = "Удалить";
            this.RemoveFrontWeapButton.UseVisualStyleBackColor = true;
            this.RemoveFrontWeapButton.Click += new System.EventHandler(this.RemoveFrontWeapButton_Click);
            // 
            // TurretWeapNumTextBox
            // 
            this.TurretWeapNumTextBox.Location = new System.Drawing.Point(194, 264);
            this.TurretWeapNumTextBox.Name = "TurretWeapNumTextBox";
            this.TurretWeapNumTextBox.Size = new System.Drawing.Size(76, 20);
            this.TurretWeapNumTextBox.TabIndex = 11;
            this.TurretWeapNumTextBox.Text = "1";
            // 
            // FrontWeapNumTextBox
            // 
            this.FrontWeapNumTextBox.Location = new System.Drawing.Point(51, 264);
            this.FrontWeapNumTextBox.Name = "FrontWeapNumTextBox";
            this.FrontWeapNumTextBox.Size = new System.Drawing.Size(76, 20);
            this.FrontWeapNumTextBox.TabIndex = 10;
            this.FrontWeapNumTextBox.Text = "1";
            // 
            // TurretNumLabel
            // 
            this.TurretNumLabel.AutoSize = true;
            this.TurretNumLabel.Location = new System.Drawing.Point(151, 267);
            this.TurretNumLabel.Name = "TurretNumLabel";
            this.TurretNumLabel.Size = new System.Drawing.Size(44, 13);
            this.TurretNumLabel.TabIndex = 9;
            this.TurretNumLabel.Text = "Кол-во:";
            // 
            // FrontNumLabel
            // 
            this.FrontNumLabel.AutoSize = true;
            this.FrontNumLabel.Location = new System.Drawing.Point(8, 267);
            this.FrontNumLabel.Name = "FrontNumLabel";
            this.FrontNumLabel.Size = new System.Drawing.Size(44, 13);
            this.FrontNumLabel.TabIndex = 8;
            this.FrontNumLabel.Text = "Кол-во:";
            // 
            // AddTurretWeapButton
            // 
            this.AddTurretWeapButton.Location = new System.Drawing.Point(154, 237);
            this.AddTurretWeapButton.Name = "AddTurretWeapButton";
            this.AddTurretWeapButton.Size = new System.Drawing.Size(116, 23);
            this.AddTurretWeapButton.TabIndex = 7;
            this.AddTurretWeapButton.Text = "Добавить";
            this.AddTurretWeapButton.UseVisualStyleBackColor = true;
            this.AddTurretWeapButton.Click += new System.EventHandler(this.AddTurretWeapButton_Click);
            // 
            // AddFrontWeapButton
            // 
            this.AddFrontWeapButton.Location = new System.Drawing.Point(11, 237);
            this.AddFrontWeapButton.Name = "AddFrontWeapButton";
            this.AddFrontWeapButton.Size = new System.Drawing.Size(116, 23);
            this.AddFrontWeapButton.TabIndex = 6;
            this.AddFrontWeapButton.Text = "Добавить";
            this.AddFrontWeapButton.UseVisualStyleBackColor = true;
            this.AddFrontWeapButton.Click += new System.EventHandler(this.AddFrontWeapButton_Click);
            // 
            // TurretWeapLabel
            // 
            this.TurretWeapLabel.AutoSize = true;
            this.TurretWeapLabel.Location = new System.Drawing.Point(150, 16);
            this.TurretWeapLabel.Name = "TurretWeapLabel";
            this.TurretWeapLabel.Size = new System.Drawing.Size(125, 13);
            this.TurretWeapLabel.TabIndex = 5;
            this.TurretWeapLabel.Text = "Турельное вооружение";
            // 
            // FrontWeapLabel
            // 
            this.FrontWeapLabel.AutoSize = true;
            this.FrontWeapLabel.Location = new System.Drawing.Point(8, 16);
            this.FrontWeapLabel.Name = "FrontWeapLabel";
            this.FrontWeapLabel.Size = new System.Drawing.Size(119, 13);
            this.FrontWeapLabel.TabIndex = 4;
            this.FrontWeapLabel.Text = "Курсовое вооружение";
            // 
            // WeaponsLabel
            // 
            this.WeaponsLabel.AutoSize = true;
            this.WeaponsLabel.Location = new System.Drawing.Point(13, 3);
            this.WeaponsLabel.Name = "WeaponsLabel";
            this.WeaponsLabel.Size = new System.Drawing.Size(108, 13);
            this.WeaponsLabel.TabIndex = 3;
            this.WeaponsLabel.Text = "Список вооружения";
            // 
            // WeaponsListBox
            // 
            this.WeaponsListBox.FormattingEnabled = true;
            this.WeaponsListBox.HorizontalScrollbar = true;
            this.WeaponsListBox.Location = new System.Drawing.Point(6, 21);
            this.WeaponsListBox.Name = "WeaponsListBox";
            this.WeaponsListBox.Size = new System.Drawing.Size(138, 381);
            this.WeaponsListBox.TabIndex = 0;
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.LightGreen;
            this.TabPage2.Controls.Add(this.SpecialSlotsGroupBox);
            this.TabPage2.Controls.Add(this.CivilSlotsGroupBox);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(440, 410);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Ячейки и модули";
            // 
            // SpecialSlotsGroupBox
            // 
            this.SpecialSlotsGroupBox.Controls.Add(this.RemoveAllSpecialSlotButton);
            this.SpecialSlotsGroupBox.Controls.Add(this.AddedSpecialSlotsLabel);
            this.SpecialSlotsGroupBox.Controls.Add(this.SpecialRemoveTextBox);
            this.SpecialSlotsGroupBox.Controls.Add(this.SpecialRemoveLabel);
            this.SpecialSlotsGroupBox.Controls.Add(this.RemoveSpecialSlotButton);
            this.SpecialSlotsGroupBox.Controls.Add(this.SpecialAddTextBox);
            this.SpecialSlotsGroupBox.Controls.Add(this.AddedSpecialSlotListBox);
            this.SpecialSlotsGroupBox.Controls.Add(this.SpecialAddLabel);
            this.SpecialSlotsGroupBox.Controls.Add(this.AddSpecialSlotButton);
            this.SpecialSlotsGroupBox.Controls.Add(this.SpecialSlotListBox);
            this.SpecialSlotsGroupBox.Controls.Add(this.SpecialSlotsLabel);
            this.SpecialSlotsGroupBox.Location = new System.Drawing.Point(215, 3);
            this.SpecialSlotsGroupBox.Name = "SpecialSlotsGroupBox";
            this.SpecialSlotsGroupBox.Size = new System.Drawing.Size(219, 373);
            this.SpecialSlotsGroupBox.TabIndex = 1;
            this.SpecialSlotsGroupBox.TabStop = false;
            this.SpecialSlotsGroupBox.Text = "Особые ячейки";
            // 
            // RemoveAllSpecialSlotButton
            // 
            this.RemoveAllSpecialSlotButton.Location = new System.Drawing.Point(133, 341);
            this.RemoveAllSpecialSlotButton.Name = "RemoveAllSpecialSlotButton";
            this.RemoveAllSpecialSlotButton.Size = new System.Drawing.Size(80, 24);
            this.RemoveAllSpecialSlotButton.TabIndex = 11;
            this.RemoveAllSpecialSlotButton.Text = "Удалить всё";
            this.RemoveAllSpecialSlotButton.UseVisualStyleBackColor = true;
            this.RemoveAllSpecialSlotButton.Click += new System.EventHandler(this.RemoveAllSpecialSlotButton_Click);
            // 
            // AddedSpecialSlotsLabel
            // 
            this.AddedSpecialSlotsLabel.AutoSize = true;
            this.AddedSpecialSlotsLabel.Location = new System.Drawing.Point(1, 347);
            this.AddedSpecialSlotsLabel.Name = "AddedSpecialSlotsLabel";
            this.AddedSpecialSlotsLabel.Size = new System.Drawing.Size(108, 13);
            this.AddedSpecialSlotsLabel.TabIndex = 10;
            this.AddedSpecialSlotsLabel.Text = "Занятые слоты: 0/0";
            // 
            // SpecialRemoveTextBox
            // 
            this.SpecialRemoveTextBox.Location = new System.Drawing.Point(47, 316);
            this.SpecialRemoveTextBox.Name = "SpecialRemoveTextBox";
            this.SpecialRemoveTextBox.Size = new System.Drawing.Size(64, 20);
            this.SpecialRemoveTextBox.TabIndex = 10;
            this.SpecialRemoveTextBox.Text = "1";
            // 
            // SpecialRemoveLabel
            // 
            this.SpecialRemoveLabel.AutoSize = true;
            this.SpecialRemoveLabel.Location = new System.Drawing.Point(6, 320);
            this.SpecialRemoveLabel.Name = "SpecialRemoveLabel";
            this.SpecialRemoveLabel.Size = new System.Drawing.Size(44, 13);
            this.SpecialRemoveLabel.TabIndex = 9;
            this.SpecialRemoveLabel.Text = "Кол-во:";
            // 
            // RemoveSpecialSlotButton
            // 
            this.RemoveSpecialSlotButton.Location = new System.Drawing.Point(111, 314);
            this.RemoveSpecialSlotButton.Name = "RemoveSpecialSlotButton";
            this.RemoveSpecialSlotButton.Size = new System.Drawing.Size(102, 24);
            this.RemoveSpecialSlotButton.TabIndex = 8;
            this.RemoveSpecialSlotButton.Text = "Удалить ячейку";
            this.RemoveSpecialSlotButton.UseVisualStyleBackColor = true;
            this.RemoveSpecialSlotButton.Click += new System.EventHandler(this.RemoveSpecialSlotButton_Click);
            // 
            // SpecialAddTextBox
            // 
            this.SpecialAddTextBox.Location = new System.Drawing.Point(47, 167);
            this.SpecialAddTextBox.Name = "SpecialAddTextBox";
            this.SpecialAddTextBox.Size = new System.Drawing.Size(64, 20);
            this.SpecialAddTextBox.TabIndex = 7;
            this.SpecialAddTextBox.Text = "1";
            // 
            // AddedSpecialSlotListBox
            // 
            this.AddedSpecialSlotListBox.FormattingEnabled = true;
            this.AddedSpecialSlotListBox.Location = new System.Drawing.Point(6, 200);
            this.AddedSpecialSlotListBox.Name = "AddedSpecialSlotListBox";
            this.AddedSpecialSlotListBox.Size = new System.Drawing.Size(207, 108);
            this.AddedSpecialSlotListBox.TabIndex = 4;
            this.AddedSpecialSlotListBox.SelectedIndexChanged += new System.EventHandler(this.AddedSpecialSlotListBox_SelectedIndexChanged);
            // 
            // SpecialAddLabel
            // 
            this.SpecialAddLabel.AutoSize = true;
            this.SpecialAddLabel.Location = new System.Drawing.Point(6, 171);
            this.SpecialAddLabel.Name = "SpecialAddLabel";
            this.SpecialAddLabel.Size = new System.Drawing.Size(44, 13);
            this.SpecialAddLabel.TabIndex = 6;
            this.SpecialAddLabel.Text = "Кол-во:";
            // 
            // AddSpecialSlotButton
            // 
            this.AddSpecialSlotButton.Location = new System.Drawing.Point(111, 165);
            this.AddSpecialSlotButton.Name = "AddSpecialSlotButton";
            this.AddSpecialSlotButton.Size = new System.Drawing.Size(102, 24);
            this.AddSpecialSlotButton.TabIndex = 3;
            this.AddSpecialSlotButton.Text = "Добавить ячейку";
            this.AddSpecialSlotButton.UseVisualStyleBackColor = true;
            this.AddSpecialSlotButton.Click += new System.EventHandler(this.AddSpecialSlotButton_Click);
            // 
            // SpecialSlotListBox
            // 
            this.SpecialSlotListBox.FormattingEnabled = true;
            this.SpecialSlotListBox.Location = new System.Drawing.Point(6, 38);
            this.SpecialSlotListBox.Name = "SpecialSlotListBox";
            this.SpecialSlotListBox.Size = new System.Drawing.Size(207, 121);
            this.SpecialSlotListBox.TabIndex = 2;
            // 
            // SpecialSlotsLabel
            // 
            this.SpecialSlotsLabel.AutoSize = true;
            this.SpecialSlotsLabel.Location = new System.Drawing.Point(52, 18);
            this.SpecialSlotsLabel.Name = "SpecialSlotsLabel";
            this.SpecialSlotsLabel.Size = new System.Drawing.Size(116, 13);
            this.SpecialSlotsLabel.TabIndex = 1;
            this.SpecialSlotsLabel.Text = "Список особых ячеек";
            // 
            // CivilSlotsGroupBox
            // 
            this.CivilSlotsGroupBox.Controls.Add(this.RemoveAllCivilSlotButton);
            this.CivilSlotsGroupBox.Controls.Add(this.AddedCivilSlotsLabel);
            this.CivilSlotsGroupBox.Controls.Add(this.CivilRemoveTextBox);
            this.CivilSlotsGroupBox.Controls.Add(this.CivilRemoveLabel);
            this.CivilSlotsGroupBox.Controls.Add(this.RemoveCivilSlotButton);
            this.CivilSlotsGroupBox.Controls.Add(this.CivilAddTextBox);
            this.CivilSlotsGroupBox.Controls.Add(this.CivilAddLlabel);
            this.CivilSlotsGroupBox.Controls.Add(this.AddedCivilSlotListBox);
            this.CivilSlotsGroupBox.Controls.Add(this.AddCivilSlotButton);
            this.CivilSlotsGroupBox.Controls.Add(this.CivilSlotListBox);
            this.CivilSlotsGroupBox.Controls.Add(this.CivilSlotsLabel);
            this.CivilSlotsGroupBox.Location = new System.Drawing.Point(6, 3);
            this.CivilSlotsGroupBox.Name = "CivilSlotsGroupBox";
            this.CivilSlotsGroupBox.Size = new System.Drawing.Size(206, 373);
            this.CivilSlotsGroupBox.TabIndex = 0;
            this.CivilSlotsGroupBox.TabStop = false;
            this.CivilSlotsGroupBox.Text = "Гражданские ячейки";
            // 
            // RemoveAllCivilSlotButton
            // 
            this.RemoveAllCivilSlotButton.Location = new System.Drawing.Point(120, 343);
            this.RemoveAllCivilSlotButton.Name = "RemoveAllCivilSlotButton";
            this.RemoveAllCivilSlotButton.Size = new System.Drawing.Size(80, 24);
            this.RemoveAllCivilSlotButton.TabIndex = 10;
            this.RemoveAllCivilSlotButton.Text = "Удалить всё";
            this.RemoveAllCivilSlotButton.UseVisualStyleBackColor = true;
            this.RemoveAllCivilSlotButton.Click += new System.EventHandler(this.RemoveAllCivilSlotButton_Click);
            // 
            // AddedCivilSlotsLabel
            // 
            this.AddedCivilSlotsLabel.AutoSize = true;
            this.AddedCivilSlotsLabel.Location = new System.Drawing.Point(1, 347);
            this.AddedCivilSlotsLabel.Name = "AddedCivilSlotsLabel";
            this.AddedCivilSlotsLabel.Size = new System.Drawing.Size(108, 13);
            this.AddedCivilSlotsLabel.TabIndex = 9;
            this.AddedCivilSlotsLabel.Text = "Занятые слоты: 0/0";
            // 
            // CivilRemoveTextBox
            // 
            this.CivilRemoveTextBox.Location = new System.Drawing.Point(44, 316);
            this.CivilRemoveTextBox.Name = "CivilRemoveTextBox";
            this.CivilRemoveTextBox.Size = new System.Drawing.Size(50, 20);
            this.CivilRemoveTextBox.TabIndex = 8;
            this.CivilRemoveTextBox.Text = "1";
            // 
            // CivilRemoveLabel
            // 
            this.CivilRemoveLabel.AutoSize = true;
            this.CivilRemoveLabel.Location = new System.Drawing.Point(3, 320);
            this.CivilRemoveLabel.Name = "CivilRemoveLabel";
            this.CivilRemoveLabel.Size = new System.Drawing.Size(44, 13);
            this.CivilRemoveLabel.TabIndex = 7;
            this.CivilRemoveLabel.Text = "Кол-во:";
            // 
            // RemoveCivilSlotButton
            // 
            this.RemoveCivilSlotButton.Location = new System.Drawing.Point(94, 314);
            this.RemoveCivilSlotButton.Name = "RemoveCivilSlotButton";
            this.RemoveCivilSlotButton.Size = new System.Drawing.Size(106, 24);
            this.RemoveCivilSlotButton.TabIndex = 6;
            this.RemoveCivilSlotButton.Text = "Удалить ячейку";
            this.RemoveCivilSlotButton.UseVisualStyleBackColor = true;
            this.RemoveCivilSlotButton.Click += new System.EventHandler(this.RemoveCivilSlotButton_Click);
            // 
            // CivilAddTextBox
            // 
            this.CivilAddTextBox.Location = new System.Drawing.Point(44, 167);
            this.CivilAddTextBox.Name = "CivilAddTextBox";
            this.CivilAddTextBox.Size = new System.Drawing.Size(50, 20);
            this.CivilAddTextBox.TabIndex = 5;
            this.CivilAddTextBox.Text = "1";
            // 
            // CivilAddLlabel
            // 
            this.CivilAddLlabel.AutoSize = true;
            this.CivilAddLlabel.Location = new System.Drawing.Point(3, 171);
            this.CivilAddLlabel.Name = "CivilAddLlabel";
            this.CivilAddLlabel.Size = new System.Drawing.Size(44, 13);
            this.CivilAddLlabel.TabIndex = 4;
            this.CivilAddLlabel.Text = "Кол-во:";
            // 
            // AddedCivilSlotListBox
            // 
            this.AddedCivilSlotListBox.FormattingEnabled = true;
            this.AddedCivilSlotListBox.Location = new System.Drawing.Point(6, 200);
            this.AddedCivilSlotListBox.Name = "AddedCivilSlotListBox";
            this.AddedCivilSlotListBox.Size = new System.Drawing.Size(194, 108);
            this.AddedCivilSlotListBox.TabIndex = 3;
            // 
            // AddCivilSlotButton
            // 
            this.AddCivilSlotButton.Location = new System.Drawing.Point(94, 165);
            this.AddCivilSlotButton.Name = "AddCivilSlotButton";
            this.AddCivilSlotButton.Size = new System.Drawing.Size(106, 24);
            this.AddCivilSlotButton.TabIndex = 2;
            this.AddCivilSlotButton.Text = "Добавить ячейку";
            this.AddCivilSlotButton.UseVisualStyleBackColor = true;
            this.AddCivilSlotButton.Click += new System.EventHandler(this.AddCivilSlotButton_Click);
            // 
            // CivilSlotListBox
            // 
            this.CivilSlotListBox.FormattingEnabled = true;
            this.CivilSlotListBox.Location = new System.Drawing.Point(6, 38);
            this.CivilSlotListBox.Name = "CivilSlotListBox";
            this.CivilSlotListBox.Size = new System.Drawing.Size(194, 121);
            this.CivilSlotListBox.TabIndex = 1;
            // 
            // CivilSlotsLabel
            // 
            this.CivilSlotsLabel.AutoSize = true;
            this.CivilSlotsLabel.Location = new System.Drawing.Point(26, 18);
            this.CivilSlotsLabel.Name = "CivilSlotsLabel";
            this.CivilSlotsLabel.Size = new System.Drawing.Size(145, 13);
            this.CivilSlotsLabel.TabIndex = 0;
            this.CivilSlotsLabel.Text = "Список гражданских ячеек";
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MainGroupBox.Controls.Add(this.ParametrsGroupBox);
            this.MainGroupBox.Controls.Add(this.PriceAddComboBox);
            this.MainGroupBox.Controls.Add(this.GMLabel);
            this.MainGroupBox.Controls.Add(this.PriceAddLabel);
            this.MainGroupBox.Controls.Add(this.AddOnGroupBox);
            this.MainGroupBox.Controls.Add(this.EnginesGroupBox);
            this.MainGroupBox.Controls.Add(this.SensorsCheckedListBox);
            this.MainGroupBox.Controls.Add(this.SensorsLabel);
            this.MainGroupBox.Controls.Add(this.NameTextBox);
            this.MainGroupBox.Controls.Add(this.NameLabel);
            this.MainGroupBox.Controls.Add(this.QualityComboBox);
            this.MainGroupBox.Controls.Add(this.QualityLabel);
            this.MainGroupBox.Controls.Add(this.ClassComboBox);
            this.MainGroupBox.Controls.Add(this.ClassLabel);
            this.MainGroupBox.Controls.Add(this.SizeComboBox);
            this.MainGroupBox.Controls.Add(this.SizeLabel);
            this.MainGroupBox.Location = new System.Drawing.Point(12, 27);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Size = new System.Drawing.Size(391, 436);
            this.MainGroupBox.TabIndex = 1;
            this.MainGroupBox.TabStop = false;
            this.MainGroupBox.Text = "Общие параметры";
            // 
            // ParametrsGroupBox
            // 
            this.ParametrsGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ParametrsGroupBox.Controls.Add(this.HullLabel);
            this.ParametrsGroupBox.Controls.Add(this.ArmorLabel);
            this.ParametrsGroupBox.Controls.Add(this.ShieldLabel);
            this.ParametrsGroupBox.Controls.Add(this.AgilityLabel);
            this.ParametrsGroupBox.Controls.Add(this.CrewLabel);
            this.ParametrsGroupBox.Controls.Add(this.ReactorLabel);
            this.ParametrsGroupBox.Location = new System.Drawing.Point(6, 164);
            this.ParametrsGroupBox.Name = "ParametrsGroupBox";
            this.ParametrsGroupBox.Size = new System.Drawing.Size(140, 142);
            this.ParametrsGroupBox.TabIndex = 22;
            this.ParametrsGroupBox.TabStop = false;
            this.ParametrsGroupBox.Text = "Характеристики";
            // 
            // HullLabel
            // 
            this.HullLabel.AutoSize = true;
            this.HullLabel.Location = new System.Drawing.Point(6, 17);
            this.HullLabel.Name = "HullLabel";
            this.HullLabel.Size = new System.Drawing.Size(69, 13);
            this.HullLabel.TabIndex = 12;
            this.HullLabel.Text = "Корпус: N/A";
            // 
            // ArmorLabel
            // 
            this.ArmorLabel.AutoSize = true;
            this.ArmorLabel.Location = new System.Drawing.Point(6, 39);
            this.ArmorLabel.Name = "ArmorLabel";
            this.ArmorLabel.Size = new System.Drawing.Size(64, 13);
            this.ArmorLabel.TabIndex = 13;
            this.ArmorLabel.Text = "Броня: N/A";
            // 
            // ShieldLabel
            // 
            this.ShieldLabel.AutoSize = true;
            this.ShieldLabel.Location = new System.Drawing.Point(6, 61);
            this.ShieldLabel.Name = "ShieldLabel";
            this.ShieldLabel.Size = new System.Drawing.Size(54, 13);
            this.ShieldLabel.TabIndex = 14;
            this.ShieldLabel.Text = "Щит: N/A";
            // 
            // AgilityLabel
            // 
            this.AgilityLabel.AutoSize = true;
            this.AgilityLabel.Location = new System.Drawing.Point(6, 83);
            this.AgilityLabel.Name = "AgilityLabel";
            this.AgilityLabel.Size = new System.Drawing.Size(113, 13);
            this.AgilityLabel.TabIndex = 15;
            this.AgilityLabel.Text = "Манёвренность: N/A";
            // 
            // CrewLabel
            // 
            this.CrewLabel.AutoSize = true;
            this.CrewLabel.Location = new System.Drawing.Point(6, 123);
            this.CrewLabel.Name = "CrewLabel";
            this.CrewLabel.Size = new System.Drawing.Size(72, 13);
            this.CrewLabel.TabIndex = 18;
            this.CrewLabel.Text = "Экипаж: от 0";
            // 
            // ReactorLabel
            // 
            this.ReactorLabel.AutoSize = true;
            this.ReactorLabel.Location = new System.Drawing.Point(6, 104);
            this.ReactorLabel.Name = "ReactorLabel";
            this.ReactorLabel.Size = new System.Drawing.Size(75, 13);
            this.ReactorLabel.TabIndex = 16;
            this.ReactorLabel.Text = "Реактор: N/A";
            // 
            // PriceAddComboBox
            // 
            this.PriceAddComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PriceAddComboBox.FormattingEnabled = true;
            this.PriceAddComboBox.Location = new System.Drawing.Point(8, 405);
            this.PriceAddComboBox.Name = "PriceAddComboBox";
            this.PriceAddComboBox.Size = new System.Drawing.Size(129, 21);
            this.PriceAddComboBox.TabIndex = 21;
            this.PriceAddComboBox.SelectedIndexChanged += new System.EventHandler(this.PriceAddComboBox_SelectedIndexChanged);
            this.PriceAddComboBox.SelectedValueChanged += new System.EventHandler(this.PriceAddComboBox_SelectedValueChanged);
            // 
            // GMLabel
            // 
            this.GMLabel.AutoSize = true;
            this.GMLabel.Location = new System.Drawing.Point(14, 385);
            this.GMLabel.Name = "GMLabel";
            this.GMLabel.Size = new System.Drawing.Size(115, 13);
            this.GMLabel.TabIndex = 20;
            this.GMLabel.Text = "(Спрашивайте у ГМ\'а)";
            // 
            // PriceAddLabel
            // 
            this.PriceAddLabel.AutoSize = true;
            this.PriceAddLabel.Location = new System.Drawing.Point(17, 372);
            this.PriceAddLabel.Name = "PriceAddLabel";
            this.PriceAddLabel.Size = new System.Drawing.Size(112, 13);
            this.PriceAddLabel.TabIndex = 19;
            this.PriceAddLabel.Text = "Наценка за покупку:";
            // 
            // AddOnGroupBox
            // 
            this.AddOnGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddOnGroupBox.Controls.Add(this.BoriCheckBox);
            this.AddOnGroupBox.Controls.Add(this.StalCheckBox);
            this.AddOnGroupBox.Controls.Add(this.ArmorThiccTextBox);
            this.AddOnGroupBox.Controls.Add(this.ArmorThiccLabel);
            this.AddOnGroupBox.Controls.Add(this.ControlUnitLabel);
            this.AddOnGroupBox.Controls.Add(this.ControlUnitComboBox);
            this.AddOnGroupBox.Controls.Add(this.HassCheckBox);
            this.AddOnGroupBox.Location = new System.Drawing.Point(155, 312);
            this.AddOnGroupBox.Name = "AddOnGroupBox";
            this.AddOnGroupBox.Size = new System.Drawing.Size(227, 118);
            this.AddOnGroupBox.TabIndex = 17;
            this.AddOnGroupBox.TabStop = false;
            this.AddOnGroupBox.Text = "Вспомогательные модули";
            // 
            // BoriCheckBox
            // 
            this.BoriCheckBox.AutoSize = true;
            this.BoriCheckBox.Location = new System.Drawing.Point(6, 56);
            this.BoriCheckBox.Name = "BoriCheckBox";
            this.BoriCheckBox.Size = new System.Drawing.Size(145, 17);
            this.BoriCheckBox.TabIndex = 6;
            this.BoriCheckBox.Text = "Корпус из Бориформия";
            this.BoriCheckBox.UseVisualStyleBackColor = true;
            this.BoriCheckBox.CheckedChanged += new System.EventHandler(this.BoriCheckBox_CheckedChanged);
            // 
            // StalCheckBox
            // 
            this.StalCheckBox.AutoSize = true;
            this.StalCheckBox.Location = new System.Drawing.Point(6, 76);
            this.StalCheckBox.Name = "StalCheckBox";
            this.StalCheckBox.Size = new System.Drawing.Size(136, 17);
            this.StalCheckBox.TabIndex = 5;
            this.StalCheckBox.Text = "Броня из Сталиниума";
            this.StalCheckBox.UseVisualStyleBackColor = true;
            this.StalCheckBox.CheckedChanged += new System.EventHandler(this.StalCheckBox_CheckedChanged);
            // 
            // ArmorThiccTextBox
            // 
            this.ArmorThiccTextBox.Location = new System.Drawing.Point(120, 33);
            this.ArmorThiccTextBox.Name = "ArmorThiccTextBox";
            this.ArmorThiccTextBox.Size = new System.Drawing.Size(96, 20);
            this.ArmorThiccTextBox.TabIndex = 4;
            this.ArmorThiccTextBox.Text = "100";
            this.ArmorThiccTextBox.TextChanged += new System.EventHandler(this.ArmorThiccTextBox_TextChanged);
            // 
            // ArmorThiccLabel
            // 
            this.ArmorThiccLabel.AutoSize = true;
            this.ArmorThiccLabel.Location = new System.Drawing.Point(117, 17);
            this.ArmorThiccLabel.Name = "ArmorThiccLabel";
            this.ArmorThiccLabel.Size = new System.Drawing.Size(103, 13);
            this.ArmorThiccLabel.TabIndex = 3;
            this.ArmorThiccLabel.Text = "Толщина брони(%):";
            // 
            // ControlUnitLabel
            // 
            this.ControlUnitLabel.AutoSize = true;
            this.ControlUnitLabel.Location = new System.Drawing.Point(9, 17);
            this.ControlUnitLabel.Name = "ControlUnitLabel";
            this.ControlUnitLabel.Size = new System.Drawing.Size(101, 13);
            this.ControlUnitLabel.TabIndex = 2;
            this.ControlUnitLabel.Text = "Метод управления";
            // 
            // ControlUnitComboBox
            // 
            this.ControlUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ControlUnitComboBox.FormattingEnabled = true;
            this.ControlUnitComboBox.Location = new System.Drawing.Point(6, 32);
            this.ControlUnitComboBox.Name = "ControlUnitComboBox";
            this.ControlUnitComboBox.Size = new System.Drawing.Size(107, 21);
            this.ControlUnitComboBox.TabIndex = 1;
            // 
            // HassCheckBox
            // 
            this.HassCheckBox.AutoSize = true;
            this.HassCheckBox.Location = new System.Drawing.Point(6, 95);
            this.HassCheckBox.Name = "HassCheckBox";
            this.HassCheckBox.Size = new System.Drawing.Size(131, 17);
            this.HassCheckBox.TabIndex = 0;
            this.HassCheckBox.Text = "Щиты из Хассатия-Б";
            this.HassCheckBox.UseVisualStyleBackColor = true;
            this.HassCheckBox.CheckedChanged += new System.EventHandler(this.HassCheckBox_CheckedChanged);
            // 
            // EnginesGroupBox
            // 
            this.EnginesGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EnginesGroupBox.Controls.Add(this.EngineTechComboBox);
            this.EnginesGroupBox.Controls.Add(this.EngineTechLvlLabel);
            this.EnginesGroupBox.Controls.Add(this.EnginesTipLabel);
            this.EnginesGroupBox.Controls.Add(this.RemoveEngineButton);
            this.EnginesGroupBox.Controls.Add(this.AddEngineButton);
            this.EnginesGroupBox.Controls.Add(this.EnginesSizeLabel);
            this.EnginesGroupBox.Controls.Add(this.EngineSizeComboBox);
            this.EnginesGroupBox.Controls.Add(this.PickedEnginesListBox);
            this.EnginesGroupBox.Controls.Add(this.EnginesListBox);
            this.EnginesGroupBox.Location = new System.Drawing.Point(155, 109);
            this.EnginesGroupBox.Name = "EnginesGroupBox";
            this.EnginesGroupBox.Size = new System.Drawing.Size(227, 197);
            this.EnginesGroupBox.TabIndex = 11;
            this.EnginesGroupBox.TabStop = false;
            this.EnginesGroupBox.Text = "Двигатели";
            // 
            // EngineTechComboBox
            // 
            this.EngineTechComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EngineTechComboBox.FormattingEnabled = true;
            this.EngineTechComboBox.Location = new System.Drawing.Point(134, 80);
            this.EngineTechComboBox.Name = "EngineTechComboBox";
            this.EngineTechComboBox.Size = new System.Drawing.Size(89, 21);
            this.EngineTechComboBox.TabIndex = 8;
            // 
            // EngineTechLvlLabel
            // 
            this.EngineTechLvlLabel.AutoSize = true;
            this.EngineTechLvlLabel.Location = new System.Drawing.Point(3, 84);
            this.EngineTechLvlLabel.Name = "EngineTechLvlLabel";
            this.EngineTechLvlLabel.Size = new System.Drawing.Size(130, 13);
            this.EngineTechLvlLabel.TabIndex = 7;
            this.EngineTechLvlLabel.Text = "Тех. уровень двигателя:";
            // 
            // EnginesTipLabel
            // 
            this.EnginesTipLabel.AutoSize = true;
            this.EnginesTipLabel.Location = new System.Drawing.Point(6, 174);
            this.EnginesTipLabel.Name = "EnginesTipLabel";
            this.EnginesTipLabel.Size = new System.Drawing.Size(107, 13);
            this.EnginesTipLabel.TabIndex = 6;
            this.EnginesTipLabel.Text = "(Макс. 4 двигателя)";
            // 
            // RemoveEngineButton
            // 
            this.RemoveEngineButton.Location = new System.Drawing.Point(148, 169);
            this.RemoveEngineButton.Name = "RemoveEngineButton";
            this.RemoveEngineButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveEngineButton.TabIndex = 5;
            this.RemoveEngineButton.Text = "Удалить";
            this.RemoveEngineButton.UseVisualStyleBackColor = true;
            this.RemoveEngineButton.Click += new System.EventHandler(this.RemoveEngineButton_Click);
            // 
            // AddEngineButton
            // 
            this.AddEngineButton.Location = new System.Drawing.Point(141, 53);
            this.AddEngineButton.Name = "AddEngineButton";
            this.AddEngineButton.Size = new System.Drawing.Size(75, 23);
            this.AddEngineButton.TabIndex = 4;
            this.AddEngineButton.Text = "Добавить";
            this.AddEngineButton.UseVisualStyleBackColor = true;
            this.AddEngineButton.Click += new System.EventHandler(this.AddEngineButton_Click);
            // 
            // EnginesSizeLabel
            // 
            this.EnginesSizeLabel.AutoSize = true;
            this.EnginesSizeLabel.Location = new System.Drawing.Point(155, 9);
            this.EnginesSizeLabel.Name = "EnginesSizeLabel";
            this.EnginesSizeLabel.Size = new System.Drawing.Size(46, 13);
            this.EnginesSizeLabel.TabIndex = 3;
            this.EnginesSizeLabel.Text = "Размер";
            // 
            // EngineSizeComboBox
            // 
            this.EngineSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EngineSizeComboBox.FormattingEnabled = true;
            this.EngineSizeComboBox.Location = new System.Drawing.Point(134, 28);
            this.EngineSizeComboBox.Name = "EngineSizeComboBox";
            this.EngineSizeComboBox.Size = new System.Drawing.Size(89, 21);
            this.EngineSizeComboBox.TabIndex = 2;
            // 
            // PickedEnginesListBox
            // 
            this.PickedEnginesListBox.FormattingEnabled = true;
            this.PickedEnginesListBox.Location = new System.Drawing.Point(6, 107);
            this.PickedEnginesListBox.Name = "PickedEnginesListBox";
            this.PickedEnginesListBox.Size = new System.Drawing.Size(217, 56);
            this.PickedEnginesListBox.TabIndex = 1;
            // 
            // EnginesListBox
            // 
            this.EnginesListBox.FormattingEnabled = true;
            this.EnginesListBox.Location = new System.Drawing.Point(6, 19);
            this.EnginesListBox.Name = "EnginesListBox";
            this.EnginesListBox.Size = new System.Drawing.Size(120, 56);
            this.EnginesListBox.TabIndex = 0;
            // 
            // SensorsCheckedListBox
            // 
            this.SensorsCheckedListBox.FormattingEnabled = true;
            this.SensorsCheckedListBox.Location = new System.Drawing.Point(6, 109);
            this.SensorsCheckedListBox.Name = "SensorsCheckedListBox";
            this.SensorsCheckedListBox.Size = new System.Drawing.Size(140, 49);
            this.SensorsCheckedListBox.TabIndex = 10;
            this.SensorsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.SensorsCheckedListBox_SelectedIndexChanged);
            this.SensorsCheckedListBox.SelectedValueChanged += new System.EventHandler(this.SensorsCheckedListBox_SelectedValueChanged);
            // 
            // SensorsLabel
            // 
            this.SensorsLabel.AutoSize = true;
            this.SensorsLabel.Location = new System.Drawing.Point(50, 93);
            this.SensorsLabel.Name = "SensorsLabel";
            this.SensorsLabel.Size = new System.Drawing.Size(52, 13);
            this.SensorsLabel.TabIndex = 8;
            this.SensorsLabel.Text = "Сенсоры";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(113, 19);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(269, 20);
            this.NameTextBox.TabIndex = 7;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(17, 22);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(92, 13);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Название судна:";
            // 
            // QualityComboBox
            // 
            this.QualityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QualityComboBox.FormattingEnabled = true;
            this.QualityComboBox.Location = new System.Drawing.Point(284, 59);
            this.QualityComboBox.Name = "QualityComboBox";
            this.QualityComboBox.Size = new System.Drawing.Size(98, 21);
            this.QualityComboBox.TabIndex = 5;
            this.QualityComboBox.SelectedIndexChanged += new System.EventHandler(this.QualityComboBox_SelectedIndexChanged);
            // 
            // QualityLabel
            // 
            this.QualityLabel.AutoSize = true;
            this.QualityLabel.Location = new System.Drawing.Point(283, 43);
            this.QualityLabel.Name = "QualityLabel";
            this.QualityLabel.Size = new System.Drawing.Size(99, 13);
            this.QualityLabel.TabIndex = 4;
            this.QualityLabel.Text = "Качество корабля";
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Location = new System.Drawing.Point(110, 59);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(172, 21);
            this.ClassComboBox.TabIndex = 3;
            this.ClassComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassComboBox_SelectedIndexChanged);
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(158, 43);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(70, 13);
            this.ClassLabel.TabIndex = 2;
            this.ClassLabel.Text = "Класс судна";
            // 
            // SizeComboBox
            // 
            this.SizeComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.SizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SizeComboBox.FormattingEnabled = true;
            this.SizeComboBox.Location = new System.Drawing.Point(6, 59);
            this.SizeComboBox.Name = "SizeComboBox";
            this.SizeComboBox.Size = new System.Drawing.Size(101, 21);
            this.SizeComboBox.TabIndex = 1;
            this.SizeComboBox.SelectedIndexChanged += new System.EventHandler(this.SizeComboBox_SelectedIndexChanged);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(17, 43);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(78, 13);
            this.SizeLabel.TabIndex = 0;
            this.SizeLabel.Text = "Размер судна";
            // 
            // RulesLinkLabel
            // 
            this.RulesLinkLabel.AutoSize = true;
            this.RulesLinkLabel.Location = new System.Drawing.Point(691, 474);
            this.RulesLinkLabel.Name = "RulesLinkLabel";
            this.RulesLinkLabel.Size = new System.Drawing.Size(159, 13);
            this.RulesLinkLabel.TabIndex = 2;
            this.RulesLinkLabel.TabStop = true;
            this.RulesLinkLabel.Text = "Правила НРИ “Ролёвка Урук”";
            this.RulesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SaveButton.Location = new System.Drawing.Point(9, 469);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(146, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Сохранить конфигурацию";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(161, 474);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(158, 13);
            this.CostLabel.TabIndex = 4;
            this.CostLabel.Text = "Итоговая стоимость:  N/A АР";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenu});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(869, 24);
            this.MenuStrip1.TabIndex = 5;
            this.MenuStrip1.Text = "Вкладка";
            // 
            // ToolStripMenu
            // 
            this.ToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.описаниеМодулейToolStripMenuItem,
            this.changeLogsToolStripMenuItem,
            this.LoadConfigurationButton});
            this.ToolStripMenu.Name = "ToolStripMenu";
            this.ToolStripMenu.Size = new System.Drawing.Size(113, 20);
            this.ToolStripMenu.Text = "Дополнительное";
            // 
            // описаниеМодулейToolStripMenuItem
            // 
            this.описаниеМодулейToolStripMenuItem.Name = "описаниеМодулейToolStripMenuItem";
            this.описаниеМодулейToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.описаниеМодулейToolStripMenuItem.Text = "Описание модулей";
            this.описаниеМодулейToolStripMenuItem.Click += new System.EventHandler(this.описаниеМодулейToolStripMenuItem_Click);
            // 
            // changeLogsToolStripMenuItem
            // 
            this.changeLogsToolStripMenuItem.Name = "changeLogsToolStripMenuItem";
            this.changeLogsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.changeLogsToolStripMenuItem.Text = "Change Logs";
            this.changeLogsToolStripMenuItem.Click += new System.EventHandler(this.changeLogsToolStripMenuItem_Click);
            // 
            // LoadConfigurationButton
            // 
            this.LoadConfigurationButton.Name = "LoadConfigurationButton";
            this.LoadConfigurationButton.Size = new System.Drawing.Size(181, 22);
            this.LoadConfigurationButton.Text = "Загрузить из файла";
            this.LoadConfigurationButton.Click += new System.EventHandler(this.LoadConfigurationButton_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(869, 496);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RulesLinkLabel);
            this.Controls.Add(this.MainGroupBox);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.MenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MenuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Конфигуратор кораблей";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.SecPropGroupBox.ResumeLayout(false);
            this.SecPropGroupBox.PerformLayout();
            this.SpeedsGroupBox.ResumeLayout(false);
            this.SpeedsGroupBox.PerformLayout();
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.CurrentWeapGroupBox.ResumeLayout(false);
            this.CurrentWeapGroupBox.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.SpecialSlotsGroupBox.ResumeLayout(false);
            this.SpecialSlotsGroupBox.PerformLayout();
            this.CivilSlotsGroupBox.ResumeLayout(false);
            this.CivilSlotsGroupBox.PerformLayout();
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ParametrsGroupBox.ResumeLayout(false);
            this.ParametrsGroupBox.PerformLayout();
            this.AddOnGroupBox.ResumeLayout(false);
            this.AddOnGroupBox.PerformLayout();
            this.EnginesGroupBox.ResumeLayout(false);
            this.EnginesGroupBox.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
