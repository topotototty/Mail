   M S B A M L   `   `   `  ����C  ?EmailApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:EmailApp.MVVM.ViewEmailApp.MVVM.View  5      A%clr-namespace:EmailApp.MVVM.ViewModelEmailApp.MVVM.ViewModel  5      g8clr-namespace:EmailApp.MVVM.ViewModel.Helpers.Converters*EmailApp.MVVM.ViewModel.Helpers.Converters  5      "    EmailApp.MVVM.View.LoginPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:EmailApp.MVVM.View     5      ` \MaterialDesignThemes.Wpf, Version=4.10.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      5	viewmodel%clr-namespace:EmailApp.MVVM.ViewModel  5      I
converters8clr-namespace:EmailApp.MVVM.ViewModel.Helpers.Converters  5        N� Title$  	LoginPage��5
       � 	Resources 5      N   HEmailApp.MVVM.ViewModel.Helpers.Converters.MultiStringToBooleanConverter !  MultiStringToBooleanConverter  CloseIconAnimation �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%\  &	        &	        5   
   63   �� 5   
   .��5      U� $8 2(UIElement.RenderTransform).(TranslateTransform.X)�6,   $
 Icon��6{   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:0.2��6'   $	 -50Q�69     5      $ 0:0:1��6'   $
 2000Q�67     5      $ 0:0:1��6'   $ 0Q�67   5      5      5      .��5      � -   5         �Name$ AnimGrid��5       J� Opacity$ 0Q�6    J� RenderTransformOrigin$ 0.5,0.5&�6)   
�������	 � Cursor$	  ��6\   z�5   
   �� 5      
 �� ScaleX$
 1Q�6    �� ScaleY$ 1Q�6(   .+�5   
   � -   5        $ 	LoginGrid��5      $��Center=�6"   $��Center=�6=    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    �� 5"      $
��Auto �6     � ColumnDefinitions 5$      �� 5%      $
��Auto �6#   �� 5&      $	��200 �6#   .+�5(      '  !MaterialDesignThemes.Wpf.PackIcon  -   5          Name$
 Icon��5*   &      Kind$ 	EmailFast=�5(   &   $	��200��67   $	��200��6C   $��2��5)   &   $��Center=�6:   ���#1a73e8z�5+      T� 5,       T� X$ 0Q�6)   5.      �� 50      $��1��6   $��0��6!   $��Email:��61   $��5q�6B   �� 51      -   5         ��Name$ EmailTextBox��51   3   $��1��6   $��1��6#   $��5q�6I   ��52      �� *	UserLogin+ �� Mode$ TwoWay=��� 54      $��2��6   $��0��6!   $��	Password:��61   $��5q�6E   �� 55      -   5        $ PasswordTextBox��55   3   $��2��6   $��1��6#   $��5q�6L   ��56      �� *UserPassword+$ TwoWay=��� 58      -   5         ��Name$ NextBtn��58   >   $��3��6   $��
Далее��6"   $	��100��62   $
	 Hand��59      ���#1a73e8
������� �� 	IsDefault . $��Center=�5:      $��10q�62   $��2��6>   ���#1a73e8 " MaterialDesignFlatDarkBgButton#���  5;   +   {�5<      `� 5=       `� 	Converter# [  6#   .1�5>      ��  �� ElementName$ EmailTextBox��6"    �� Path$
 Text�6=   �� 5?      $ PasswordTextBox��6"   $
 Text�6@   5@      5B      5C      � 5E   
   -   5        $ ServerSelectionGrid��5E      $y�Hidden=�6,    5F      �� 5G      �� 5H      $	��260 �6#   �� 5I       5K      �� 5L      �� 5M      $	��250 �6    �� 5N      .+�5Q      �� $��Choose mail service.��6   $��Center=�63   $��3��5R      $��Bottom=�6(   $��0 30 0 0q�6C   $��32(�6U   �� 5T      -   5        $ rambler��5U      $��0��5T      $��1��6%   $
	 Hand��5U   "   $��Right=�5V        ServiceButtonStyle#���  5X      ��5Y      �� *RamblerSelectedCommand+.��5Z      � $	��190��6   $	��190��6$   .+�5[        -	   5        $ RamblerIcon��5]   "   $ CheckCircle=�5[   .   $��30��6B   $��30��6M   $��10q�6Y   $	��Top=�5\   "   $��Right=�6:   ���#1a73e8$y�Hidden=�5^   "   �� 5_      $��Assets/rambler.png��6   $��100px��68   5`      5a      �� 5b      -
   5        $ gmail��5c      $��1��5b      $��1��6%   $
	 Hand��5c   $   #���  5d      ��5e      �� *GmailSelectedCommand+.��5g      � $	��190��6   $	��190��6$   .+�5h        -   5        $ 	GmailIcon��5j   &   $ CheckCircle=�5h   .   $��30��6B   $��30��6M   $��10q�6Y   $	��Top=�5i   &   $��Right=�6>   ���#1a73e8$y�Hidden=�5k   &   �� 5l      $��Assets/gmail.png��6   $��100px��66   5m      5n      �� 5o      -   5        $ yandex��5q      $��2��5o      $��1��6%   $
	 Hand��62   $
��Left=�5p      #���  5r      ��5q   %   �� *YandexSelectedCommand+.��5s      � $	��190��6   $	��190��6$   .+�5t        -   5        $ 
YandexIcon��5v   &   $ CheckCircle=�5t   .   $��30��6A   $��30��6L   $��10q�6X   $	��Top=�5u   &   $��Right=�6>   ���#1a73e8$y�Hidden=�5w   &   �� 5x      $��Assets/yandex.png��6   $��100px��67   5y      5z      �� 5|      -   5        $ BackBtn��5~   (   $��2��5|      $��0��6"   $��
Назад��62   $	��100��6B   $��Right=�5}      $	��Top=�61   $��	0 20 70 0q�5~      $
	 Hand��5      ���#1a73e8
����������#1a73e8   MaterialDesignOutlinedButton#���  5�   +   �� 5�      -   5        $ LoginBtn��5�   (   $��2��5�      $��2��6"   $��
Войти��62   $	��100��6B   $
	 Hand��5�      ���#1a73e8
�������$
��Left=�5�      $	��Top=�60   $��	70 20 0 0q�5�      {�.  ���#1a73e8#���  5�   +    . ��5�   L   �� *LoginCommand+5�   d   5�      5�      5�      