   M S B A M L   `   `   `  ����D  @ZIASystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ZIASystem.ViewsZIASystem.Views  5   	   !    ZIASystem.Views.AdminWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ZIASystem.Views     5   	     � Title$  AdminWindow��5   	   $	��450��6   $	��800��6*   .��5	      � ���#F7F7F7 � ColumnDefinitions 5
   
   �� 5      $��3* �6   �� 5      $��7* �6   .+�5   
   � $��0��6   ���#333333.+�5      �� .+�5      �� -   5         ��Name$ companies_btn��5      $��	Companies��60   $��10q�5      ���#007ACC
�������$
��Bold"�6M   $��50��6_   �� 5      -   5        $ hospitals_btn��5      $��	Hospitals��60   $��10q�5      ���#007ACC
�������$
��Bold"�6M   $��50��6_   �� 5      -   5        $ dayRecords_btn��5      $��Day Records��61   $��10q�5      ���#007ACC
�������$
��Bold"�6M   $��50��6_   �� 5      -   5        $ viewReport_btn��5      $��View Report��61   $��10q�5      ���#007ACC
�������$
��Bold"�6M   $��50��6_   5      5      � 5   
   -   5         �Name$ 	view_grid��5      $��1��6"   $��9.6,0,-10.4,0q�62   .+�5      �� -   5        $��Txtbx��5   1   $
��Left=�6   $��23��6>   $��-153,282,0,0q�6J    �� TextWrapping$
 Wrap=�6`   $��Enter Id��6t   $	��Top=�6�   $	��120��6�   �� 5      -   5        $��Button��5   M   $��Search For Clinics��6   $
��Left=�62   $��-210,310,0,0q�6[   $	��Top=�6q   $	��133��6�   6�   �� 5      -   5        $��Cmbobx��5   2   $
��Left=�6   $��-153,356,0,0q�6@   $	��Top=�6V   $	��120��6n   �� 5      $��Hospital Id��6   $
��Left=�6*   $��-238,279,0,0q�6E   $	��Top=�6[   $��68��6s   �� 5      $��Clinics��6   $
��Left=�6&   $��-224,356,0,0q�6A   $	��Top=�6W    J� RenderTransformOrigin$ 0.156,0.461&�6o   5!      5"      5#      