   M S B A M L   `   `   `  ����I  ETsuStoryEngine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TsuStoryEngineTsuStoryEngine  5          TsuStoryEngine.Title   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:TsuStoryEngine     5        N� Title$  Title��5	      .��5      � -   5         �Name$	 myG��5      .+�5   
   �� -   5         ��Name$ title��5      $
��Left=�6   $	��720��6:   $	��Top=�6G   $
��1280��6_   $.��(C:\Resources\TsuStoryEngine\im\title.jpg��6l    J� Effect 5      -  'System.Windows.Media.Effects.BlurEffect  5      5      �� 5   
   $��Blend WPF Engine��6   $
��Left=�6+   $��673.5,46,0,0q�6F   $	��Top=�6\   $��72(�6t   $��606.5��6�   �� 5   
   -   5         ��Name$ slabel��5      $��起動準備中...��6    $
��Left=�63   $��853,568,0,0q�6N   $	��Top=�6c   $��72(�6{    � Triggers 5      :� 5       :� RoutedEvent$ Label.Loaded��6   .[�5      �� .��5      �� -   5        .��5      W�  �� 
TargetName$ slabel��5   !    �� TargetProperty$ Opacity�5   !   	 W� From$	 0X�5   !   	
 W� To$
 1X�5   !    g� Duration$ 0:0:2D�5   !   W� 5      $ bl��5    !   $ Opacity�5!   !   $	 0X�5"   !   $
 1X�5#   !   $ 0:0:1D�5$   !   5&      5'      5(      5+      �� 5,   
   -   5         ��Name$ bl��5,      $
��Left=�6   $	��720��69   $	��Top=�6F   $
��1280��6^   ���	#7F0202026k   �� 5-   
   $
��Left=�6   $��88��6-   $	��Top=�69   $
��1280��6Q   ���	#7F020202$��	0,304,0,0q�6u   $��0q�6�   �� 5.   
   -   5        $ lt��5.      $��Preparing...��6   $
��Left=�63   $	��Top=�6N   $��328,310,0,0q�6f   $��48(�6{   
������� 5/      3  -System.Windows.Media.Effects.DropShadowEffect  50      52      �� 53   
   -   5         ��Name$ 	up_button��53      $��Update��6$   $
��Left=�65   $��525,440,0,0q�6P   $	��Top=�6e   $	��222��6}   $��72��6�   ���	#7F39A3CB
�������$��48(�6�   $��0q�6�   $y�Hidden=�6�   6�   54      55      