   M S B A M L   `   `   `  ����D  @ZIASystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:ZIASystem.Views.UserControlsZIASystem.Views.UserControls  5   C  3    -ZIASystem.Views.UserControls.AdminAddRemoveUC   6   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6F   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6�   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6�   @d2http://schemas.microsoft.com/expression/blend/2008     6  <local*clr-namespace:ZIASystem.Views.UserControls     6C  -   5        .��5      � ���#F5F5F5  � RowDefinitions  5   
   �� 5      $��5* �6   �� 5      $��2* �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5	      &   System.Windows.Controls.DataGrid  -   5          Name$ DGrid��5	      $
��Left=�6&   $	��318��6A   $��	10,10,0,0q�6N   $	��Top=�6a   $	��780��6y   5
      � 5   
   $��1��6   $��0,5.2,0,21.6q�6   .+�5      �� -   5         ��Name$ id_txt��5      $
��Left=�6&   $��23��6A   $��	81,60,0,0q�6M    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��129��6�   �� 5      $��ID��6   $
��Left=�6!   $	��Top=�6<    J� RenderTransformOrigin$ 1.243,1.719&�6T   $��	54,57,0,0q�6x   �� 5      -   5        $ name_txt��5      $
��Left=�6(   $��23��6C   $��
336,60,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��129��6�   �� 5      $
��Name��6   $
��Left=�6#   $	��Top=�6>   $ 1.243,1.719&�6V   $��
289,60,0,0q�6z   �� 5      -   5        $ address_txt��5      $
��Left=�6+   $��23��6F   $��
611,57,0,0q�6R   $
 Wrap=�6f   $	��Top=�6z   $	��129��6�   �� 5      $��Address��6   $
��Left=�6&   $	��Top=�6A   $ 1.243,1.719&�6Y   $��
558,57,0,0q�6}   5      � 5   
   $��2��6   .+�5      �� -   5         ��Name$ add_btn��5      $	��ADD��6&   $
��Left=�6J   $��
184,10,0,0q�6e   $	��Top=�6y   $	��141��6�   $��36��6�   ���#2196F36�   �� 5      -   5        $ remove��5      $��REMOVE��6%   $
��Left=�6K   $��
517,10,0,0q�6f   $	��Top=�6z   $	��141��6�   $��36��6�   ���#F443366�   5      5      5      