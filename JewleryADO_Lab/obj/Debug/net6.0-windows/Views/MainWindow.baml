   M S B A M L   `   `   `  ����I  EJewleryADO_Lab, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:JewleryADO_Lab.ViewsJewleryADO_Lab.Views  5   	   /clr-namespace:JewleryADO_LabJewleryADO_Lab  5   	   E'clr-namespace:JewleryADO_Lab.ConvertersJewleryADO_Lab.Converters  5   	       JewleryADO_Lab.MainWindow   5   	   ,Views"clr-namespace:JewleryADO_Lab.Views  W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:JewleryADO_Lab     5   	   =	Converter'clr-namespace:JewleryADO_Lab.Converters     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5      0   *JewleryADO_Lab.Converters.VisibleConverter   my:VisibleConverter��%   &	          5   
   6%   5      .��5      �  � RowDefinitions 5   
   �� 5      $��48 �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6    � UseLayoutRounding$ False��6"   $
��Left=�6<    �� Orientation$ 
Horizontal=�6W   5      �� 5   
   $��1��6   .+�5      $   JewleryADO_Lab.Views.ClientsUC  -   5          Name$ 	ClientsUC��5      y�61   ��  �� Path$ 
VisibleTab� �� ConverterParameter$ Clients��"   JewleryADO_Lab.Views.GoodsUC  5      -   5          Name$ GoodsUC��5      y�6-   �� $ 
VisibleTab�$ Goods��&    JewleryADO_Lab.Views.MaterialsUC  5      -   5        	  Name$	 MaterialsUC��5       y�65   �� $ 
VisibleTab�$ 	Materials��#   JewleryADO_Lab.Views.OrdersUC  5      -   5        
  Name$
 OrdersUC��5      y�6/   �� $ 
VisibleTab�$ Orders��5      5      5      