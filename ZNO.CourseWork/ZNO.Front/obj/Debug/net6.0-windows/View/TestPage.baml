   M S B A M L   `   `   `  ����D  @ZNO.Front, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ZNO.Front.ViewZNO.Front.View  5          ZNO.Front.View.TestPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:ZNO.Front.View     5         ColorBrush.None  N� 
Background#  [  5	       N� Title$' !Минулорічні тести��5       � DataContext 5
      ��   ViewModelLocator �� Source# [  �� Path$ TestViewModel�.��5      �  � RowDefinitions 5   
   �� 5      $��60 �6   6*   �� 5      $��60 �6   6*   �� 5      $��60 �6   6*   �� 5      $��60 �6   6*   �� 5      $��60 �6   6*   �� 5      $��60 �6   6*   �� 5      $��60 �6   6*   �� 5      6    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $	��350 �6   6-   �� 5      $��* �6   6+   .+�5   
   �� $��1��6   $��1��6!   $
��2021��5       $��10, 0q�5!      
�������  Button.CommandButton#��[ 5#      $	��0,5q�5$      $	��100��5&      ��5%      �� *OpenLink2021Command+5&      �� 5(   
   $��1��6   $��2��6!   $
��2020��5)      $��10, 0q�5*      
�������#��[ 5,      $	��0,5q�5-      $	��100��5/      ��5.      �� *OpenLink2020Command+5/      �� 51   
   $��1��6   $��3��6!   $
��2019��52      $��10, 0q�53      
�������#��[ 55      $	��0,5q�56      $	��100��58      ��57      �� *OpenLink2019Command+58      �� 5:   
   $��1��6   $��4��6!   $
��2018��5;      $��10, 0q�5<      
�������#��[ 5>      $	��0,5q�5?      $	��100��5A      ��5@      �� *OpenLink2018Command+5A      �� 5D   
   $��1��6   $��5��6!   $��Інші роки��5E      $��10, 0q�5F      
�������#��[ 5H      $	��0,5q�5I      $	��100��5K      ��5J      �� *OpenLinkCommand+5K      5M      5N      