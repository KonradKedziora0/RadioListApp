   M S B A M L   `   `   `  ���� J  FRadioList-v.1.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:RadioList_v._1._0RadioList_v._1._0  "    RadioList_v._1._0.MainWindow   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:RadioList_v._1._0       � Title$  	RadioList��$	��470��$	��800�� � WindowStyle$ SingleBorderWindow=� � 
ResizeMode$ CanMinimize=�.��� .+��� -    ��Name$ stationListView��$��
0,10,0,186q� J� RenderTransformOrigin$ 0.506,0.418&�$��Center=�$	��782��$ �� IsSynchronizedWithCurrentItem$ FalseY� �� View �� .P��� $
��Name�� �� Width$	 140�� �� DisplayMemberBinding �� *Name+�� $��Country��$	 140�� �� *	Country+�� $��Description��$	 140�� �� *Description+�� $	��URL��$	 335�� �� *Url+�� -   	 ��Name$	 stationNameTextBox��$
��Left=�$��101,258,0,0q�
 �� TextWrapping$

 Wrap=�$	��Top=�$	��120��$��26������  �� ElementName$ stationListView�� �� Path$ SelectedItem.Name� �� Mode$ TwoWay=��� $
��Name��$
��Left=�$��
10,255,0,0q�$	��Top=�$��60��$
��Bold"�$��12(��� -   $	 stationCountryTextBox��$
��Left=�$��101,291,0,0q�$

 Wrap=�$	��Top=�$	��120��$��26������ $ stationListView��$ SelectedItem.Country�$ TwoWay=��� $��Country��$
��Left=�$��
10,288,0,0q�$	��Top=�$��67��$
��Bold"�$��12(��� -   $	 stationUrlTextBox��$
��Left=�$��101,322,0,0q�$

 Wrap=�$	��Top=�$	��120��$��26������ $ stationListView��$ SelectedItem.Url�$ TwoWay=��� $	��URL��$
��Left=�$��
10,322,0,0q�$	��Top=�$��60��$
��Bold"�$��12(��� -   $	 stationDescriptionTextBox��$
��Left=�$��101,353,0,0q�$

 Wrap=�$	��Top=�$	��120��$��26��$ 0.501,0.351&����� $ stationListView��$ SelectedItem.Description�$ TwoWay=��� $��Description��$
��Left=�$��
10,349,0,0q�$	��Top=�$��86��$
��Bold"�$��12(��� -   $
��Left=�$��
10,387,0,0q�$	��Top=�$��30��$��82��.��]� $��42��.+��� $��12(�$��Normal"�$��Center=�Add�� $"��/Resources/Icons/Add_16x.png��$��12��$��0,0,0,0q�$��12���� -   $
��Left=�$��
97,387,0,0q�$	��Top=�$��30��$��82��.��]� .+��� $��12(�$��Normal"�Delete�� $-��'/Resources/Icons/DeleteTableRow_16x.png��$��12��$��5,0,0,0q�$��12���� -   $
��Left=�$��184,387,0,0q�$	��Top=�$��30��$��82��.��]� .+��� -	   $��12(�$��Normal"�Update�� $-��'/Resources/Icons/UpdateListItem_16x.png��$��12��$��5,0,0,0q�$��12���� -
   $
��Left=�$��271,387,0,0q�$	��Top=�$��30��$��82��.��]� .+��� $��12(�$��Normal"�	Refresh�� $&�� /Resources/Icons/Restart_16x.png��$��12��$��5,0,0,0q�$��12���� -   $
��Left=�$��360,387,0,0q�$	��Top=�$��30��$��82��.��]� -   .+��� $��12(�$��Normal"�Clear�� $(��"/Resources/Icons/CleanData_16x.png��$��12��$��5,0,0,0q�$��12���� -   $
��Left=�$��
54,322,0,0q�$	��Top=�$��26��$��40��$��10(�.���� .+��� $��12(�$��Normal"�Copy�� -   $
��Left=�$��272,352,0,0q�$	��Top=�$��30��$��82��.��]� .+��� $��12(�$��Normal"�Play�� $0��*/Resources/Icons/StartWithoutDebug_16x.png��$��12��$��5,0,0,0q�$��12���� -   $
��Left=�$��360,352,0,0q�$	��Top=�$��30��$��82��.��]� .+��� $��12(�$��Normal"�Stop�� $#��/Resources/Icons/Stop_16x.png��$��12��$��5,0,0,0q�$��12��	� -    	�Name$ nameRadioButton��$
��Left=�$��534,264,0,0q�$	��Top=�.���� .+��� �� $��12(�$��Normal"�Name	� -   $ countryRadioButton��$
��Left=�$��611,264,0,0q�$	��Top=�.���� .+��� �� $��12(�$��Normal"�	Country	� -   $ descriptionRadioButton��$
��Left=�$��690,264,0,0q�$	��Top=�.���� .+��� �� $��12(�$��Normal"�Description�� -   $	 searchTextBox��$
��Left=�$��534,291,0,0q�$

 Wrap=�$	��Top=�$	��120��$��26���� -   $
��Left=�$��669,291,0,0q�$	��Top=�$��26��$	��100��.��]� .+��� $��12(�$��Normal"�Search�� $'��!/Resources/Icons/VBSearch_16x.png��$��12��$��5,0,0,0q�$��12��