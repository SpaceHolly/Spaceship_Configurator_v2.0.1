using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ShipConfigurator
{
	public class Change_log : Form
	{
		private Label label1;

		private Label label3;

		private Label label4;

		private Label label5;

		private Label label6;

		private Label label7;

		private Label label8;

		private Label label9;

		private Label label10;

		private Label label11;

		private Label label12;

		private Label label13;

		private Label label14;

		private Label label15;

		private Label label16;

		private Label label17;

		private Label label18;

		private Label label19;

		private Label label20;

		private Label label21;

		private Label label22;

		private Label label23;

		private Label label24;

		private Label label25;

		private Label label26;

		private Label label27;

		private Label label28;

		private Label label29;

		private Label label30;

		private Label label31;

		private Label label32;

		private Label label33;

		private TabControl tabControl1;

		private TabPage tabPage1;

		private TabPage tabPage2;

		private TabPage tabPage3;

		private TabPage tabPage4;

		private TabPage tabPage5;

		private TabPage tabPage6;

		private TabPage tabPage7;

		private TabPage tabPage8;

		private TabPage tabPage9;

		private TabPage tabPage10;

		private Label label34;

		private Label label35;

		private Label label36;

		private Label label37;

		private Label label38;

		private TabPage tabPage11;

		private Label label40;

		private Label label41;

		private Label label42;

		private Label label39;

		private Label label43;

		private Label label44;

		private TabPage tabPage12;

		private Label label45;

		private Label label48;

		private Label label47;

		private Label label46;

		private Label label50;

		private Label label49;

		private Label label2;

		private IContainer components;

		private TabPage tabPage13;

		private Label label55;

		private Label label54;

		private Label label53;

		private Label label52;

		private Label label51;

		private Label label57;

		private Label label56;

		private Label label58;

		public Change_log()
		{
			InitializeComponent();
			InitializeData();
		}

		private void InitializeData()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Change_log));
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			label10 = new Label();
			label11 = new Label();
			label12 = new Label();
			label13 = new Label();
			label14 = new Label();
			label15 = new Label();
			label16 = new Label();
			label17 = new Label();
			label18 = new Label();
			label19 = new Label();
			label20 = new Label();
			label21 = new Label();
			label22 = new Label();
			label23 = new Label();
			label24 = new Label();
			label25 = new Label();
			label26 = new Label();
			label27 = new Label();
			label28 = new Label();
			label29 = new Label();
			label30 = new Label();
			label31 = new Label();
			label32 = new Label();
			label33 = new Label();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			tabPage2 = new TabPage();
			tabPage3 = new TabPage();
			tabPage4 = new TabPage();
			tabPage5 = new TabPage();
			tabPage6 = new TabPage();
			tabPage7 = new TabPage();
			tabPage8 = new TabPage();
			tabPage9 = new TabPage();
			tabPage10 = new TabPage();
			label38 = new Label();
			label34 = new Label();
			label35 = new Label();
			label36 = new Label();
			label37 = new Label();
			tabPage11 = new TabPage();
			label44 = new Label();
			label43 = new Label();
			label40 = new Label();
			label41 = new Label();
			label42 = new Label();
			label39 = new Label();
			tabPage12 = new TabPage();
			label48 = new Label();
			label47 = new Label();
			label46 = new Label();
			label45 = new Label();
			label49 = new Label();
			label50 = new Label();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			tabPage2.SuspendLayout();
			tabPage3.SuspendLayout();
			tabPage4.SuspendLayout();
			tabPage5.SuspendLayout();
			tabPage6.SuspendLayout();
			tabPage7.SuspendLayout();
			tabPage8.SuspendLayout();
			tabPage9.SuspendLayout();
			tabPage10.SuspendLayout();
			tabPage11.SuspendLayout();
			tabPage12.SuspendLayout();
			SuspendLayout();
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Sans Serif", 14.25f);
			label1.Location = new Point(6, 3);
			label1.Name = "label1";
			label1.Size = new Size(120, 24);
			label1.TabIndex = 0;
			label1.Text = "Версия 0.1.1";
			label1.Click += label1_Click;
			label2.AutoSize = true;
			label2.Location = new Point(7, 36);
			label2.Name = "label2";
			label2.Size = new Size(244, 13);
			label2.TabIndex = 1;
			label2.Text = "- Достигнута полноценная работа приложения";
			label3.AutoSize = true;
			label3.Location = new Point(6, 37);
			label3.Name = "label3";
			label3.Size = new Size(293, 13);
			label3.TabIndex = 3;
			label3.Text = "- Fixed: Модификаторы теперь отображаются корректно";
			label4.AutoSize = true;
			label4.Font = new Font("Microsoft Sans Serif", 14.25f);
			label4.Location = new Point(6, 3);
			label4.Name = "label4";
			label4.Size = new Size(120, 24);
			label4.TabIndex = 2;
			label4.Text = "Версия 0.2.1";
			label5.AutoSize = true;
			label5.Location = new Point(7, 60);
			label5.Name = "label5";
			label5.Size = new Size(300, 13);
			label5.TabIndex = 4;
			label5.Text = "- Fixed: Теперь нельзя изменять значения характеристик";
			label6.AutoSize = true;
			label6.Location = new Point(7, 36);
			label6.Name = "label6";
			label6.Size = new Size(317, 13);
			label6.TabIndex = 6;
			label6.Text = "- Добавлена возможность выбора размера всех двигателей";
			label6.Click += label6_Click;
			label7.AutoSize = true;
			label7.Font = new Font("Microsoft Sans Serif", 14.25f);
			label7.Location = new Point(6, 3);
			label7.Name = "label7";
			label7.Size = new Size(120, 24);
			label7.TabIndex = 5;
			label7.Text = "Версия 0.3.1";
			label7.Click += label7_Click;
			label8.AutoSize = true;
			label8.Location = new Point(7, 58);
			label8.Name = "label8";
			label8.Size = new Size(317, 13);
			label8.TabIndex = 7;
			label8.Text = "- Fixed: Теперь нельзя изменять значения класса и размера";
			label8.Click += label8_Click;
			label9.AutoSize = true;
			label9.Location = new Point(6, 80);
			label9.Name = "label9";
			label9.Size = new Size(496, 13);
			label9.TabIndex = 8;
			label9.Text = "- Fixed: Ползунки на добавление гражданских и специальных ячеек теперь работают корректно";
			label9.Click += label9_Click;
			label10.AutoSize = true;
			label10.Location = new Point(6, 102);
			label10.Name = "label10";
			label10.Size = new Size(404, 13);
			label10.TabIndex = 9;
			label10.Text = "- Fixed: Исправлена ошибка при добавлении турелей значение всегда равно 0";
			label10.Click += label10_Click;
			label11.AutoSize = true;
			label11.Font = new Font("Microsoft Sans Serif", 14.25f);
			label11.Location = new Point(6, 3);
			label11.Name = "label11";
			label11.Size = new Size(120, 24);
			label11.TabIndex = 10;
			label11.Text = "Версия 0.4.1";
			label12.AutoSize = true;
			label12.Location = new Point(6, 38);
			label12.Name = "label12";
			label12.Size = new Size(431, 13);
			label12.TabIndex = 11;
			label12.Text = "- Добавлена возможность выбрать размер для каждого двигателя индивидуально";
			label13.AutoSize = true;
			label13.Location = new Point(6, 60);
			label13.Name = "label13";
			label13.Size = new Size(352, 13);
			label13.TabIndex = 12;
			label13.Text = "- Модификаторы перемещены в другое место и более не ломаются";
			label14.AutoSize = true;
			label14.Font = new Font("Microsoft Sans Serif", 14.25f);
			label14.Location = new Point(6, 3);
			label14.Name = "label14";
			label14.Size = new Size(120, 24);
			label14.TabIndex = 13;
			label14.Text = "Версия 0.5.1";
			label15.AutoSize = true;
			label15.Location = new Point(8, 36);
			label15.Name = "label15";
			label15.Size = new Size(310, 13);
			label15.TabIndex = 14;
			label15.Text = "- Полное изменение интерфейса на более удобный формат";
			label15.Click += label15_Click;
			label16.AutoSize = true;
			label16.Font = new Font("Microsoft Sans Serif", 14.25f);
			label16.Location = new Point(6, 3);
			label16.Name = "label16";
			label16.Size = new Size(120, 24);
			label16.TabIndex = 15;
			label16.Text = "Версия 0.6.1";
			label17.AutoSize = true;
			label17.Location = new Point(7, 58);
			label17.Name = "label17";
			label17.Size = new Size(237, 13);
			label17.TabIndex = 16;
			label17.Text = "- Изменение интерфейса выбора двигателей";
			label18.AutoSize = true;
			label18.Location = new Point(7, 37);
			label18.Name = "label18";
			label18.Size = new Size(147, 13);
			label18.TabIndex = 17;
			label18.Text = "- Мелкие изменения в коде";
			label19.AutoSize = true;
			label19.Location = new Point(6, 82);
			label19.Name = "label19";
			label19.Size = new Size(440, 13);
			label19.TabIndex = 18;
			label19.Text = "- Fixed: Приложение теперь имеет фиксированные рамки, которые нельзя изменять";
			label20.AutoSize = true;
			label20.Font = new Font("Microsoft Sans Serif", 14.25f);
			label20.Location = new Point(6, 3);
			label20.Name = "label20";
			label20.Size = new Size(120, 24);
			label20.TabIndex = 19;
			label20.Text = "Версия 0.7.1";
			label21.AutoSize = true;
			label21.Location = new Point(8, 38);
			label21.Name = "label21";
			label21.Size = new Size(147, 13);
			label21.TabIndex = 20;
			label21.Text = "- Мелкие изменения в коде";
			label22.AutoSize = true;
			label22.Location = new Point(7, 60);
			label22.Name = "label22";
			label22.Size = new Size(122, 13);
			label22.TabIndex = 21;
			label22.Text = "- Добавлены пасхалки";
			label23.AutoSize = true;
			label23.Location = new Point(8, 80);
			label23.Name = "label23";
			label23.Size = new Size(171, 13);
			label23.TabIndex = 22;
			label23.Text = "- Добавлена ссылка на правила";
			label24.AutoSize = true;
			label24.Location = new Point(8, 82);
			label24.Name = "label24";
			label24.Size = new Size(394, 13);
			label24.TabIndex = 23;
			label24.Text = "- Добавлены все ранее не добавленые гражданские и специальные ячейки";
			label24.Click += label24_Click;
			label25.AutoSize = true;
			label25.Font = new Font("Microsoft Sans Serif", 14.25f);
			label25.Location = new Point(6, 3);
			label25.Name = "label25";
			label25.Size = new Size(120, 24);
			label25.TabIndex = 24;
			label25.Text = "Версия 1.0.0";
			label25.Click += label25_Click;
			label26.AutoSize = true;
			label26.Location = new Point(7, 37);
			label26.Name = "label26";
			label26.Size = new Size(193, 13);
			label26.TabIndex = 25;
			label26.Text = "- Испраление незначительных багов";
			label27.AutoSize = true;
			label27.Location = new Point(7, 59);
			label27.Name = "label27";
			label27.Size = new Size(328, 13);
			label27.TabIndex = 26;
			label27.Text = "- Публикация приложения на сервер USSE в публичный доступ";
			label28.AutoSize = true;
			label28.Font = new Font("Microsoft Sans Serif", 14.25f);
			label28.Location = new Point(6, 3);
			label28.Name = "label28";
			label28.Size = new Size(120, 24);
			label28.TabIndex = 27;
			label28.Text = "Версия 1.0.1";
			label29.AutoSize = true;
			label29.Location = new Point(7, 36);
			label29.Name = "label29";
			label29.Size = new Size(240, 13);
			label29.TabIndex = 28;
			label29.Text = "- Fixed: В размере S не отображался эсминец";
			label30.AutoSize = true;
			label30.Location = new Point(7, 58);
			label30.Name = "label30";
			label30.Size = new Size(291, 13);
			label30.TabIndex = 29;
			label30.Text = "- Fixed: В списке вооружения не отображалась \"Пушка\"";
			label31.AutoSize = true;
			label31.Location = new Point(5, 81);
			label31.Name = "label31";
			label31.Size = new Size(226, 13);
			label31.TabIndex = 30;
			label31.Text = "- Добавлен Список изменений (Change log)";
			label32.AutoSize = true;
			label32.Location = new Point(5, 103);
			label32.Name = "label32";
			label32.Size = new Size(171, 13);
			label32.TabIndex = 31;
			label32.Text = "- Добавлена кнопка \"Обновить\"";
			label33.AutoSize = true;
			label33.Location = new Point(5, 125);
			label33.Name = "label33";
			label33.Size = new Size(227, 13);
			label33.TabIndex = 32;
			label33.Text = "- Обновлена ссыка на актуальные правила";
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Controls.Add(tabPage3);
			tabControl1.Controls.Add(tabPage4);
			tabControl1.Controls.Add(tabPage5);
			tabControl1.Controls.Add(tabPage6);
			tabControl1.Controls.Add(tabPage7);
			tabControl1.Controls.Add(tabPage8);
			tabControl1.Controls.Add(tabPage9);
			tabControl1.Controls.Add(tabPage10);
			tabControl1.Controls.Add(tabPage11);
			tabControl1.Controls.Add(tabPage12);
			tabControl1.Location = new Point(12, 12);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(509, 172);
			tabControl1.TabIndex = 33;
			tabPage1.Controls.Add(label1);
			tabPage1.Controls.Add(label2);
			tabPage1.Location = new Point(4, 22);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(501, 146);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Версия 0.1.1";
			tabPage1.UseVisualStyleBackColor = true;
			tabPage2.Controls.Add(label4);
			tabPage2.Controls.Add(label3);
			tabPage2.Controls.Add(label5);
			tabPage2.Location = new Point(4, 22);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(501, 146);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Версия 0.2.1";
			tabPage2.UseVisualStyleBackColor = true;
			tabPage3.Controls.Add(label7);
			tabPage3.Controls.Add(label6);
			tabPage3.Controls.Add(label8);
			tabPage3.Controls.Add(label9);
			tabPage3.Controls.Add(label10);
			tabPage3.Location = new Point(4, 22);
			tabPage3.Name = "tabPage3";
			tabPage3.Padding = new Padding(3);
			tabPage3.Size = new Size(501, 146);
			tabPage3.TabIndex = 2;
			tabPage3.Text = "Версия 0.3.1";
			tabPage3.UseVisualStyleBackColor = true;
			tabPage3.Click += tabPage3_Click;
			tabPage4.Controls.Add(label11);
			tabPage4.Controls.Add(label12);
			tabPage4.Controls.Add(label13);
			tabPage4.Controls.Add(label19);
			tabPage4.Location = new Point(4, 22);
			tabPage4.Name = "tabPage4";
			tabPage4.Padding = new Padding(3);
			tabPage4.Size = new Size(501, 146);
			tabPage4.TabIndex = 3;
			tabPage4.Text = "Версия 0.4.1";
			tabPage4.UseVisualStyleBackColor = true;
			tabPage5.Controls.Add(label14);
			tabPage5.Controls.Add(label15);
			tabPage5.Controls.Add(label17);
			tabPage5.Controls.Add(label23);
			tabPage5.Location = new Point(4, 22);
			tabPage5.Name = "tabPage5";
			tabPage5.Padding = new Padding(3);
			tabPage5.Size = new Size(501, 146);
			tabPage5.TabIndex = 4;
			tabPage5.Text = "Версия 0.5.1";
			tabPage5.UseVisualStyleBackColor = true;
			tabPage6.Controls.Add(label16);
			tabPage6.Controls.Add(label18);
			tabPage6.Location = new Point(4, 22);
			tabPage6.Name = "tabPage6";
			tabPage6.Padding = new Padding(3);
			tabPage6.Size = new Size(501, 146);
			tabPage6.TabIndex = 5;
			tabPage6.Text = "Версия 0.6.1";
			tabPage6.UseVisualStyleBackColor = true;
			tabPage7.Controls.Add(label20);
			tabPage7.Controls.Add(label21);
			tabPage7.Controls.Add(label22);
			tabPage7.Controls.Add(label24);
			tabPage7.Location = new Point(4, 22);
			tabPage7.Name = "tabPage7";
			tabPage7.Padding = new Padding(3);
			tabPage7.Size = new Size(501, 146);
			tabPage7.TabIndex = 6;
			tabPage7.Text = "Версия 0.7.1";
			tabPage7.UseVisualStyleBackColor = true;
			tabPage8.Controls.Add(label25);
			tabPage8.Controls.Add(label26);
			tabPage8.Controls.Add(label27);
			tabPage8.Location = new Point(4, 22);
			tabPage8.Name = "tabPage8";
			tabPage8.Padding = new Padding(3);
			tabPage8.Size = new Size(501, 146);
			tabPage8.TabIndex = 7;
			tabPage8.Text = "Версия 1.0.0";
			tabPage8.UseVisualStyleBackColor = true;
			tabPage9.Controls.Add(label28);
			tabPage9.Controls.Add(label33);
			tabPage9.Controls.Add(label29);
			tabPage9.Controls.Add(label32);
			tabPage9.Controls.Add(label30);
			tabPage9.Controls.Add(label31);
			tabPage9.Location = new Point(4, 22);
			tabPage9.Name = "tabPage9";
			tabPage9.Padding = new Padding(3);
			tabPage9.Size = new Size(501, 146);
			tabPage9.TabIndex = 8;
			tabPage9.Text = "Версия 1.0.1";
			tabPage9.UseVisualStyleBackColor = true;
			tabPage10.Controls.Add(label38);
			tabPage10.Controls.Add(label34);
			tabPage10.Controls.Add(label35);
			tabPage10.Controls.Add(label36);
			tabPage10.Controls.Add(label37);
			tabPage10.Location = new Point(4, 22);
			tabPage10.Name = "tabPage10";
			tabPage10.Padding = new Padding(3);
			tabPage10.Size = new Size(501, 146);
			tabPage10.TabIndex = 9;
			tabPage10.Text = "Версия 1.0.2";
			tabPage10.UseVisualStyleBackColor = true;
			label38.AutoSize = true;
			label38.Location = new Point(7, 103);
			label38.Name = "label38";
			label38.Size = new Size(382, 13);
			label38.TabIndex = 35;
			label38.Text = "- Удалена ненужная часть кода (на производительность это не повлияет)";
			label34.AutoSize = true;
			label34.Font = new Font("Microsoft Sans Serif", 14.25f);
			label34.Location = new Point(6, 3);
			label34.Name = "label34";
			label34.Size = new Size(120, 24);
			label34.TabIndex = 31;
			label34.Text = "Версия 1.0.2";
			label35.AutoSize = true;
			label35.Location = new Point(7, 36);
			label35.Name = "label35";
			label35.Size = new Size(223, 13);
			label35.TabIndex = 32;
			label35.Text = "- Добавлен расчёт скорости для кораблей";
			label36.AutoSize = true;
			label36.Location = new Point(7, 58);
			label36.Name = "label36";
			label36.Size = new Size(274, 13);
			label36.TabIndex = 33;
			label36.Text = "- Изменён интерфейс основного окна и Change log'a";
			label37.AutoSize = true;
			label37.Location = new Point(5, 81);
			label37.Name = "label37";
			label37.Size = new Size(390, 13);
			label37.TabIndex = 34;
			label37.Text = "- Сенсоры, двигатели и основа кораблей перенесены в отдельную вкладку";
			tabPage11.Controls.Add(label44);
			tabPage11.Controls.Add(label43);
			tabPage11.Controls.Add(label40);
			tabPage11.Controls.Add(label41);
			tabPage11.Controls.Add(label42);
			tabPage11.Controls.Add(label39);
			tabPage11.Location = new Point(4, 22);
			tabPage11.Name = "tabPage11";
			tabPage11.Padding = new Padding(3);
			tabPage11.Size = new Size(501, 146);
			tabPage11.TabIndex = 10;
			tabPage11.Text = "Версия 1.1.0";
			tabPage11.UseVisualStyleBackColor = true;
			label44.AutoSize = true;
			label44.Location = new Point(7, 96);
			label44.Name = "label44";
			label44.Size = new Size(210, 13);
			label44.TabIndex = 39;
			label44.Text = "- Было исправлено ОЧЕНЬ много багов";
			label43.AutoSize = true;
			label43.Location = new Point(7, 74);
			label43.Name = "label43";
			label43.Size = new Size(489, 13);
			label43.TabIndex = 38;
			label43.Text = "- Добавлены 4 новых класса кораблей: Станция-маячёк, Перехватчик, Штурмовик, Универсал";
			label43.Click += label43_Click;
			label40.AutoSize = true;
			label40.Location = new Point(7, 30);
			label40.Name = "label40";
			label40.Size = new Size(213, 13);
			label40.TabIndex = 35;
			label40.Text = "- Добавлен расчёт потребления энергии";
			label41.AutoSize = true;
			label41.Location = new Point(7, 118);
			label41.Name = "label41";
			label41.Size = new Size(446, 13);
			label41.TabIndex = 36;
			label41.Text = "- Изменено: основа корабля теперь на первой странице и открывается по-умолчанию";
			label41.Click += label41_Click;
			label42.AutoSize = true;
			label42.Location = new Point(7, 52);
			label42.Name = "label42";
			label42.Size = new Size(235, 13);
			label42.TabIndex = 37;
			label42.Text = "- Добавлен модификатор \"Качество сборки\"";
			label39.AutoSize = true;
			label39.Font = new Font("Microsoft Sans Serif", 14.25f);
			label39.Location = new Point(6, 3);
			label39.Name = "label39";
			label39.Size = new Size(120, 24);
			label39.TabIndex = 32;
			label39.Text = "Версия 1.1.0";
			tabPage12.Controls.Add(label50);
			tabPage12.Controls.Add(label49);
			tabPage12.Controls.Add(label48);
			tabPage12.Controls.Add(label47);
			tabPage12.Controls.Add(label46);
			tabPage12.Controls.Add(label45);
			tabPage12.Location = new Point(4, 22);
			tabPage12.Name = "tabPage12";
			tabPage12.Padding = new Padding(3);
			tabPage12.Size = new Size(501, 146);
			tabPage12.TabIndex = 11;
			tabPage12.Text = "Версия 1.1.1_NE_2";
			tabPage12.UseVisualStyleBackColor = true;
			label48.AutoSize = true;
			label48.Location = new Point(6, 80);
			label48.Name = "label48";
			label48.Size = new Size(244, 13);
			label48.TabIndex = 42;
			label48.Text = "- Модификаторы теперь называется описание";
			label47.AutoSize = true;
			label47.Location = new Point(6, 58);
			label47.Name = "label47";
			label47.Size = new Size(349, 13);
			label47.TabIndex = 41;
			label47.Text = "- Отключение предупреждений от превышении мощности реактора";
			label46.AutoSize = true;
			label46.Location = new Point(6, 36);
			label46.Name = "label46";
			label46.Size = new Size(192, 13);
			label46.TabIndex = 40;
			label46.Text = "- Было исправлено несколько багов";
			label45.AutoSize = true;
			label45.Font = new Font("Microsoft Sans Serif", 14.25f);
			label45.Location = new Point(6, 3);
			label45.Name = "label45";
			label45.Size = new Size(177, 24);
			label45.TabIndex = 33;
			label45.Text = "Версия 1.1.1_NE_2";
			label49.AutoSize = true;
			label49.Location = new Point(7, 103);
			label49.Name = "label49";
			label49.Size = new Size(267, 13);
			label49.TabIndex = 43;
			label49.Text = "- Исправлено несколько орфографических ошибок";
			label50.AutoSize = true;
			label50.Location = new Point(7, 125);
			label50.Name = "label50";
			label50.Size = new Size(407, 13);
			label50.TabIndex = 44;
			label50.Text = "- Усилители брони, щитов и манёвренности теперь влияют на характеристики";
			base.ClientSize = new Size(529, 197);
			base.Controls.Add(tabControl1);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Change_log";
			Text = "Изменения в приложении";
			base.Load += Change_log_Load;
			tabControl1.ResumeLayout(performLayout: false);
			tabPage1.ResumeLayout(performLayout: false);
			tabPage1.PerformLayout();
			tabPage2.ResumeLayout(performLayout: false);
			tabPage2.PerformLayout();
			tabPage3.ResumeLayout(performLayout: false);
			tabPage3.PerformLayout();
			tabPage4.ResumeLayout(performLayout: false);
			tabPage4.PerformLayout();
			tabPage5.ResumeLayout(performLayout: false);
			tabPage5.PerformLayout();
			tabPage6.ResumeLayout(performLayout: false);
			tabPage6.PerformLayout();
			tabPage7.ResumeLayout(performLayout: false);
			tabPage7.PerformLayout();
			tabPage8.ResumeLayout(performLayout: false);
			tabPage8.PerformLayout();
			tabPage9.ResumeLayout(performLayout: false);
			tabPage9.PerformLayout();
			tabPage10.ResumeLayout(performLayout: false);
			tabPage10.PerformLayout();
			tabPage11.ResumeLayout(performLayout: false);
			tabPage11.PerformLayout();
			tabPage12.ResumeLayout(performLayout: false);
			tabPage12.PerformLayout();
			ResumeLayout(performLayout: false);
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void label7_Click(object sender, EventArgs e)
		{
		}

		private void label6_Click(object sender, EventArgs e)
		{
		}

		private void label8_Click(object sender, EventArgs e)
		{
		}

		private void label10_Click(object sender, EventArgs e)
		{
		}

		private void label9_Click(object sender, EventArgs e)
		{
		}

		private void label24_Click(object sender, EventArgs e)
		{
		}

		private void label15_Click(object sender, EventArgs e)
		{
		}

		private void Change_log_Load(object sender, EventArgs e)
		{
		}

		private void tabPage3_Click(object sender, EventArgs e)
		{
		}

		private void label25_Click(object sender, EventArgs e)
		{
		}

		private void label41_Click(object sender, EventArgs e)
		{
		}

		private void label43_Click(object sender, EventArgs e)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShipConfigurator.Change_log));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.tabPage8 = new System.Windows.Forms.TabPage();
			this.tabPage9 = new System.Windows.Forms.TabPage();
			this.tabPage10 = new System.Windows.Forms.TabPage();
			this.label38 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.label37 = new System.Windows.Forms.Label();
			this.tabPage11 = new System.Windows.Forms.TabPage();
			this.label44 = new System.Windows.Forms.Label();
			this.label43 = new System.Windows.Forms.Label();
			this.label40 = new System.Windows.Forms.Label();
			this.label41 = new System.Windows.Forms.Label();
			this.label42 = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.tabPage12 = new System.Windows.Forms.TabPage();
			this.label50 = new System.Windows.Forms.Label();
			this.label49 = new System.Windows.Forms.Label();
			this.label48 = new System.Windows.Forms.Label();
			this.label47 = new System.Windows.Forms.Label();
			this.label46 = new System.Windows.Forms.Label();
			this.label45 = new System.Windows.Forms.Label();
			this.tabPage13 = new System.Windows.Forms.TabPage();
			this.label51 = new System.Windows.Forms.Label();
			this.label52 = new System.Windows.Forms.Label();
			this.label53 = new System.Windows.Forms.Label();
			this.label54 = new System.Windows.Forms.Label();
			this.label55 = new System.Windows.Forms.Label();
			this.label56 = new System.Windows.Forms.Label();
			this.label57 = new System.Windows.Forms.Label();
			this.label58 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.tabPage7.SuspendLayout();
			this.tabPage8.SuspendLayout();
			this.tabPage9.SuspendLayout();
			this.tabPage10.SuspendLayout();
			this.tabPage11.SuspendLayout();
			this.tabPage12.SuspendLayout();
			this.tabPage13.SuspendLayout();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f);
			this.label1.Location = new System.Drawing.Point(6, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Версия 0.1.1";
			this.label1.Click += new System.EventHandler(label1_Click);
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(244, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "- Достигнута полноценная работа приложения";
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(293, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "- Fixed: Модификаторы теперь отображаются корректно";
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f);
			this.label4.Location = new System.Drawing.Point(6, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 24);
			this.label4.TabIndex = 2;
			this.label4.Text = "Версия 0.2.1";
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 60);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(300, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "- Fixed: Теперь нельзя изменять значения характеристик";
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 36);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(317, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "- Добавлена возможность выбора размера всех двигателей";
			this.label6.Click += new System.EventHandler(label6_Click);
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f);
			this.label7.Location = new System.Drawing.Point(6, 3);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(120, 24);
			this.label7.TabIndex = 5;
			this.label7.Text = "Версия 0.3.1";
			this.label7.Click += new System.EventHandler(label7_Click);
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 58);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(317, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "- Fixed: Теперь нельзя изменять значения класса и размера";
			this.label8.Click += new System.EventHandler(label8_Click);
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 80);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(496, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "- Fixed: Ползунки на добавление гражданских и специальных ячеек теперь работают корректно";
			this.label9.Click += new System.EventHandler(label9_Click);
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 102);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(404, 13);
			this.label10.TabIndex = 9;
			this.label10.Text = "- Fixed: Исправлена ошибка при добавлении турелей значение всегда равно 0";
			this.label10.Click += new System.EventHandler(label10_Click);
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f);
			this.label11.Location = new System.Drawing.Point(6, 3);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(120, 24);
			this.label11.TabIndex = 10;
			this.label11.Text = "Версия 0.4.1";
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 38);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(431, 13);
			this.label12.TabIndex = 11;
			this.label12.Text = "- Добавлена возможность выбрать размер для каждого двигателя индивидуально";
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(6, 60);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(352, 13);
			this.label13.TabIndex = 12;
			this.label13.Text = "- Модификаторы перемещены в другое место и более не ломаются";
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f);
			this.label14.Location = new System.Drawing.Point(6, 3);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(120, 24);
			this.label14.TabIndex = 13;
			this.label14.Text = "Версия 0.5.1";
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(8, 36);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(310, 13);
			this.label15.TabIndex = 14;
			this.label15.Text = "- Полное изменение интерфейса на более удобный формат";
			this.label15.Click += new System.EventHandler(label15_Click);
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f);
			this.label16.Location = new System.Drawing.Point(6, 3);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(120, 24);
			this.label16.TabIndex = 15;
			this.label16.Text = "Версия 0.6.1";
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(7, 58);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(237, 13);
			this.label17.TabIndex = 16;
			this.label17.Text = "- Изменение интерфейса выбора двигателей";
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(7, 37);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(147, 13);
			this.label18.TabIndex = 17;
			this.label18.Text = "- Мелкие изменения в коде";
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(6, 82);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(440, 13);
			this.label19.TabIndex = 18;
			this.label19.Text = "- Fixed: Приложение теперь имеет фиксированные рамки, которые нельзя изменять";
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f);
			this.label20.Location = new System.Drawing.Point(6, 3);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(120, 24);
			this.label20.TabIndex = 19;
			this.label20.Text = "Версия 0.7.1";
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(8, 38);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(147, 13);
			this.label21.TabIndex = 20;
			this.label21.Text = "- Мелкие изменения в коде";
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(7, 60);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(122, 13);
			this.label22.TabIndex = 21;
			this.label22.Text = "- Добавлены пасхалки";
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(8, 80);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(171, 13);
			this.label23.TabIndex = 22;
			this.label23.Text = "- Добавлена ссылка на правила";
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(8, 82);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(394, 13);
			this.label24.TabIndex = 23;
			this.label24.Text = "- Добавлены все ранее не добавленые гражданские и специальные ячейки";
			this.label24.Click += new System.EventHandler(label24_Click);
			this.label25.AutoSize = true;
			this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f);
			this.label25.Location = new System.Drawing.Point(6, 3);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(120, 24);
			this.label25.TabIndex = 24;
			this.label25.Text = "Версия 1.0.0";
			this.label25.Click += new System.EventHandler(label25_Click);
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(7, 37);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(193, 13);
			this.label26.TabIndex = 25;
			this.label26.Text = "- Испраление незначительных багов";
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(7, 59);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(328, 13);
			this.label27.TabIndex = 26;
			this.label27.Text = "- Публикация приложения на сервер USSE в публичный доступ";
			this.label28.AutoSize = true;
			this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f);
			this.label28.Location = new System.Drawing.Point(6, 3);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(120, 24);
			this.label28.TabIndex = 27;
			this.label28.Text = "Версия 1.0.1";
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(7, 36);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(240, 13);
			this.label29.TabIndex = 28;
			this.label29.Text = "- Fixed: В размере S не отображался эсминец";
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(7, 58);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(291, 13);
			this.label30.TabIndex = 29;
			this.label30.Text = "- Fixed: В списке вооружения не отображалась \"Пушка\"";
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(5, 81);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(226, 13);
			this.label31.TabIndex = 30;
			this.label31.Text = "- Добавлен Список изменений (Change log)";
			this.label32.AutoSize = true;
			this.label32.Location = new System.Drawing.Point(5, 103);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(171, 13);
			this.label32.TabIndex = 31;
			this.label32.Text = "- Добавлена кнопка \"Обновить\"";
			this.label33.AutoSize = true;
			this.label33.Location = new System.Drawing.Point(5, 125);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(227, 13);
			this.label33.TabIndex = 32;
			this.label33.Text = "- Обновлена ссыка на актуальные правила";
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Controls.Add(this.tabPage7);
			this.tabControl1.Controls.Add(this.tabPage8);
			this.tabControl1.Controls.Add(this.tabPage9);
			this.tabControl1.Controls.Add(this.tabPage10);
			this.tabControl1.Controls.Add(this.tabPage11);
			this.tabControl1.Controls.Add(this.tabPage12);
			this.tabControl1.Controls.Add(this.tabPage13);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(509, 172);
			this.tabControl1.TabIndex = 33;
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(501, 146);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Версия 0.1.1";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(501, 146);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Версия 0.2.1";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Controls.Add(this.label6);
			this.tabPage3.Controls.Add(this.label8);
			this.tabPage3.Controls.Add(this.label9);
			this.tabPage3.Controls.Add(this.label10);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(501, 146);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Версия 0.3.1";
			this.tabPage3.UseVisualStyleBackColor = true;
			this.tabPage3.Click += new System.EventHandler(tabPage3_Click);
			this.tabPage4.Controls.Add(this.label11);
			this.tabPage4.Controls.Add(this.label12);
			this.tabPage4.Controls.Add(this.label13);
			this.tabPage4.Controls.Add(this.label19);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(501, 146);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Версия 0.4.1";
			this.tabPage4.UseVisualStyleBackColor = true;
			this.tabPage5.Controls.Add(this.label14);
			this.tabPage5.Controls.Add(this.label15);
			this.tabPage5.Controls.Add(this.label17);
			this.tabPage5.Controls.Add(this.label23);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(501, 146);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Версия 0.5.1";
			this.tabPage5.UseVisualStyleBackColor = true;
			this.tabPage6.Controls.Add(this.label16);
			this.tabPage6.Controls.Add(this.label18);
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage6.Size = new System.Drawing.Size(501, 146);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "Версия 0.6.1";
			this.tabPage6.UseVisualStyleBackColor = true;
			this.tabPage7.Controls.Add(this.label20);
			this.tabPage7.Controls.Add(this.label21);
			this.tabPage7.Controls.Add(this.label22);
			this.tabPage7.Controls.Add(this.label24);
			this.tabPage7.Location = new System.Drawing.Point(4, 22);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage7.Size = new System.Drawing.Size(501, 146);
			this.tabPage7.TabIndex = 6;
			this.tabPage7.Text = "Версия 0.7.1";
			this.tabPage7.UseVisualStyleBackColor = true;
			this.tabPage8.Controls.Add(this.label25);
			this.tabPage8.Controls.Add(this.label26);
			this.tabPage8.Controls.Add(this.label27);
			this.tabPage8.Location = new System.Drawing.Point(4, 22);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage8.Size = new System.Drawing.Size(501, 146);
			this.tabPage8.TabIndex = 7;
			this.tabPage8.Text = "Версия 1.0.0";
			this.tabPage8.UseVisualStyleBackColor = true;
			this.tabPage9.Controls.Add(this.label28);
			this.tabPage9.Controls.Add(this.label33);
			this.tabPage9.Controls.Add(this.label29);
			this.tabPage9.Controls.Add(this.label32);
			this.tabPage9.Controls.Add(this.label30);
			this.tabPage9.Controls.Add(this.label31);
			this.tabPage9.Location = new System.Drawing.Point(4, 22);
			this.tabPage9.Name = "tabPage9";
			this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage9.Size = new System.Drawing.Size(501, 146);
			this.tabPage9.TabIndex = 8;
			this.tabPage9.Text = "Версия 1.0.1";
			this.tabPage9.UseVisualStyleBackColor = true;
			this.tabPage10.Controls.Add(this.label38);
			this.tabPage10.Controls.Add(this.label34);
			this.tabPage10.Controls.Add(this.label35);
			this.tabPage10.Controls.Add(this.label36);
			this.tabPage10.Controls.Add(this.label37);
			this.tabPage10.Location = new System.Drawing.Point(4, 22);
			this.tabPage10.Name = "tabPage10";
			this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage10.Size = new System.Drawing.Size(501, 146);
			this.tabPage10.TabIndex = 9;
			this.tabPage10.Text = "Версия 1.0.2";
			this.tabPage10.UseVisualStyleBackColor = true;
			this.label38.AutoSize = true;
			this.label38.Location = new System.Drawing.Point(7, 103);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(382, 13);
			this.label38.TabIndex = 35;
			this.label38.Text = "- Удалена ненужная часть кода (на производительность это не повлияет)";
			this.label34.AutoSize = true;
			this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f);
			this.label34.Location = new System.Drawing.Point(6, 3);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(120, 24);
			this.label34.TabIndex = 31;
			this.label34.Text = "Версия 1.0.2";
			this.label35.AutoSize = true;
			this.label35.Location = new System.Drawing.Point(7, 36);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(223, 13);
			this.label35.TabIndex = 32;
			this.label35.Text = "- Добавлен расчёт скорости для кораблей";
			this.label36.AutoSize = true;
			this.label36.Location = new System.Drawing.Point(7, 58);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(274, 13);
			this.label36.TabIndex = 33;
			this.label36.Text = "- Изменён интерфейс основного окна и Change log'a";
			this.label37.AutoSize = true;
			this.label37.Location = new System.Drawing.Point(5, 81);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(390, 13);
			this.label37.TabIndex = 34;
			this.label37.Text = "- Сенсоры, двигатели и основа кораблей перенесены в отдельную вкладку";
			this.tabPage11.Controls.Add(this.label44);
			this.tabPage11.Controls.Add(this.label43);
			this.tabPage11.Controls.Add(this.label40);
			this.tabPage11.Controls.Add(this.label41);
			this.tabPage11.Controls.Add(this.label42);
			this.tabPage11.Controls.Add(this.label39);
			this.tabPage11.Location = new System.Drawing.Point(4, 22);
			this.tabPage11.Name = "tabPage11";
			this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage11.Size = new System.Drawing.Size(501, 146);
			this.tabPage11.TabIndex = 10;
			this.tabPage11.Text = "Версия 1.1.0";
			this.tabPage11.UseVisualStyleBackColor = true;
			this.label44.AutoSize = true;
			this.label44.Location = new System.Drawing.Point(7, 96);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(210, 13);
			this.label44.TabIndex = 39;
			this.label44.Text = "- Было исправлено ОЧЕНЬ много багов";
			this.label43.AutoSize = true;
			this.label43.Location = new System.Drawing.Point(7, 74);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(489, 13);
			this.label43.TabIndex = 38;
			this.label43.Text = "- Добавлены 4 новых класса кораблей: Станция-маячёк, Перехватчик, Штурмовик, Универсал";
			this.label43.Click += new System.EventHandler(label43_Click);
			this.label40.AutoSize = true;
			this.label40.Location = new System.Drawing.Point(7, 30);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(213, 13);
			this.label40.TabIndex = 35;
			this.label40.Text = "- Добавлен расчёт потребления энергии";
			this.label41.AutoSize = true;
			this.label41.Location = new System.Drawing.Point(7, 118);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(446, 13);
			this.label41.TabIndex = 36;
			this.label41.Text = "- Изменено: основа корабля теперь на первой странице и открывается по-умолчанию";
			this.label41.Click += new System.EventHandler(label41_Click);
			this.label42.AutoSize = true;
			this.label42.Location = new System.Drawing.Point(7, 52);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(235, 13);
			this.label42.TabIndex = 37;
			this.label42.Text = "- Добавлен модификатор \"Качество сборки\"";
			this.label39.AutoSize = true;
			this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f);
			this.label39.Location = new System.Drawing.Point(6, 3);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(120, 24);
			this.label39.TabIndex = 32;
			this.label39.Text = "Версия 1.1.0";
			this.tabPage12.Controls.Add(this.label50);
			this.tabPage12.Controls.Add(this.label49);
			this.tabPage12.Controls.Add(this.label48);
			this.tabPage12.Controls.Add(this.label47);
			this.tabPage12.Controls.Add(this.label46);
			this.tabPage12.Controls.Add(this.label45);
			this.tabPage12.Location = new System.Drawing.Point(4, 22);
			this.tabPage12.Name = "tabPage12";
			this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage12.Size = new System.Drawing.Size(501, 146);
			this.tabPage12.TabIndex = 11;
			this.tabPage12.Text = "Версия 1.1.1_NE_2";
			this.tabPage12.UseVisualStyleBackColor = true;
			this.label50.AutoSize = true;
			this.label50.Location = new System.Drawing.Point(7, 125);
			this.label50.Name = "label50";
			this.label50.Size = new System.Drawing.Size(407, 13);
			this.label50.TabIndex = 44;
			this.label50.Text = "- Усилители брони, щитов и манёвренности теперь влияют на характеристики";
			this.label49.AutoSize = true;
			this.label49.Location = new System.Drawing.Point(7, 103);
			this.label49.Name = "label49";
			this.label49.Size = new System.Drawing.Size(267, 13);
			this.label49.TabIndex = 43;
			this.label49.Text = "- Исправлено несколько орфографических ошибок";
			this.label48.AutoSize = true;
			this.label48.Location = new System.Drawing.Point(6, 80);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(244, 13);
			this.label48.TabIndex = 42;
			this.label48.Text = "- Модификаторы теперь называется описание";
			this.label47.AutoSize = true;
			this.label47.Location = new System.Drawing.Point(6, 58);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(349, 13);
			this.label47.TabIndex = 41;
			this.label47.Text = "- Отключение предупреждений от превышении мощности реактора";
			this.label46.AutoSize = true;
			this.label46.Location = new System.Drawing.Point(6, 36);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(192, 13);
			this.label46.TabIndex = 40;
			this.label46.Text = "- Было исправлено несколько багов";
			this.label45.AutoSize = true;
			this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f);
			this.label45.Location = new System.Drawing.Point(6, 3);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(177, 24);
			this.label45.TabIndex = 33;
			this.label45.Text = "Версия 1.1.1_NE_2";
			this.tabPage13.Controls.Add(this.label58);
			this.tabPage13.Controls.Add(this.label57);
			this.tabPage13.Controls.Add(this.label56);
			this.tabPage13.Controls.Add(this.label55);
			this.tabPage13.Controls.Add(this.label54);
			this.tabPage13.Controls.Add(this.label53);
			this.tabPage13.Controls.Add(this.label52);
			this.tabPage13.Controls.Add(this.label51);
			this.tabPage13.Location = new System.Drawing.Point(4, 22);
			this.tabPage13.Name = "tabPage13";
			this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage13.Size = new System.Drawing.Size(501, 146);
			this.tabPage13.TabIndex = 12;
			this.tabPage13.Text = "Версия 2.0.0";
			this.tabPage13.UseVisualStyleBackColor = true;
			this.label51.AutoSize = true;
			this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f);
			this.label51.Location = new System.Drawing.Point(6, 3);
			this.label51.Name = "label51";
			this.label51.Size = new System.Drawing.Size(120, 24);
			this.label51.TabIndex = 34;
			this.label51.Text = "Версия 2.0.0";
			this.label52.AutoSize = true;
			this.label52.Location = new System.Drawing.Point(7, 30);
			this.label52.Name = "label52";
			this.label52.Size = new System.Drawing.Size(397, 13);
			this.label52.TabIndex = 41;
			this.label52.Text = "- Полный переход на новый код, в результате чего пропали все старые баги";
			this.label53.AutoSize = true;
			this.label53.Location = new System.Drawing.Point(7, 47);
			this.label53.Name = "label53";
			this.label53.Size = new System.Drawing.Size(371, 13);
			this.label53.TabIndex = 42;
			this.label53.Text = "- Новый внешний вид интерфейса, более приятный нежели чем раньше";
			this.label54.AutoSize = true;
			this.label54.Location = new System.Drawing.Point(6, 63);
			this.label54.Name = "label54";
			this.label54.Size = new System.Drawing.Size(488, 13);
			this.label54.TabIndex = 43;
			this.label54.Text = "- Были добавлены: техуровни двигателей, толщина брони, модификаторы для корпуса/брони/";
			this.label55.AutoSize = true;
			this.label55.Location = new System.Drawing.Point(6, 78);
			this.label55.Name = "label55";
			this.label55.Size = new System.Drawing.Size(496, 13);
			this.label55.TabIndex = 44;
			this.label55.Text = "щита, Label'ы отображающие значения складов/ангаров и наценка за покупку Б/У или верфью";
			this.label56.AutoSize = true;
			this.label56.Location = new System.Drawing.Point(3, 93);
			this.label56.Name = "label56";
			this.label56.Size = new System.Drawing.Size(450, 13);
			this.label56.TabIndex = 45;
			this.label56.Text = "- Добавлена кнопка \"Описание модулей\", в метод сохранения добавлен формат JSON";
			this.label57.AutoSize = true;
			this.label57.Location = new System.Drawing.Point(3, 108);
			this.label57.Name = "label57";
			this.label57.Size = new System.Drawing.Size(276, 13);
			this.label57.TabIndex = 46;
			this.label57.Text = "- Кнопка \"Обновить\" была убрана за ненадобностью";
			this.label58.AutoSize = true;
			this.label58.Location = new System.Drawing.Point(3, 123);
			this.label58.Name = "label58";
			this.label58.Size = new System.Drawing.Size(439, 13);
			this.label58.TabIndex = 47;
			this.label58.Text = "- Убраны старые \"пасхалки\", слайдеры были заменены на более удобные TextBox'ы";
			base.ClientSize = new System.Drawing.Size(529, 197);
			base.Controls.Add(this.tabControl1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Change_log";
			this.Text = "Изменения в приложении";
			base.Load += new System.EventHandler(Change_log_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.tabPage5.ResumeLayout(false);
			this.tabPage5.PerformLayout();
			this.tabPage6.ResumeLayout(false);
			this.tabPage6.PerformLayout();
			this.tabPage7.ResumeLayout(false);
			this.tabPage7.PerformLayout();
			this.tabPage8.ResumeLayout(false);
			this.tabPage8.PerformLayout();
			this.tabPage9.ResumeLayout(false);
			this.tabPage9.PerformLayout();
			this.tabPage10.ResumeLayout(false);
			this.tabPage10.PerformLayout();
			this.tabPage11.ResumeLayout(false);
			this.tabPage11.PerformLayout();
			this.tabPage12.ResumeLayout(false);
			this.tabPage12.PerformLayout();
			this.tabPage13.ResumeLayout(false);
			this.tabPage13.PerformLayout();
			base.ResumeLayout(false);
		}
	}
}
