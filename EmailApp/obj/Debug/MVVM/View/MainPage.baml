   M S B A M L   `   `   `  ����C  ?EmailApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:EmailApp.MVVM.ViewEmailApp.MVVM.View  5      A%clr-namespace:EmailApp.MVVM.ViewModelEmailApp.MVVM.ViewModel  6   g8clr-namespace:EmailApp.MVVM.ViewModel.Helpers.Converters*EmailApp.MVVM.ViewModel.Helpers.Converters  6�   !    EmailApp.MVVM.View.MainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:EmailApp.MVVM.View     5      ` \MaterialDesignThemes.Wpf, Version=4.10.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  66   5	viewmodel%clr-namespace:EmailApp.MVVM.ViewModel  6   I
converters8clr-namespace:EmailApp.MVVM.ViewModel.Helpers.Converters  6�     N� Title$  MainPage��5	       � 	Resources 5
      N   HEmailApp.MVVM.ViewModel.Helpers.Converters.MultiStringToBooleanConverter !  MultiStringToBooleanConverter��%   &	          5   
   63   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��4* �6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      .+�5   
   �� -   5         ��Name$ NewMessageBtn��5      $��10q�6(     FormatButtonStyle#���  64   ���#e9f1eb$	��120��6u   $
��Left=�6�   .��6�   Новое сообщение6�   �� 5   
   $��1��6   
���������6   �� *	Folders+ �� SelectedItem 6?   �� *SelectedFolder+6g   �� 5   
   -   5         ��Name$ 	EmailList��5      $��1��6%   $��1��62   ��6B   �� *Emails+ 6a   �� *SelectedEmail+��5      �� 5      .R�5      �� .+�5      �� $
��Bold"�6=   ��6$   �� *	subject+6=   �� 5      ��6$   �� *from+�� 5       ��6$   �� *date+5!      5"      5$      � 5%   
   $y�Hidden=�6   $��1��6#   $��1��60   
������� 5&      �� 5'      $��40 �6    �� 5(      .+�5*      �� -   5        $ CloseWebBtn��5*      #���  6*   $��30��5+      
���  ��
�������$��Right=�6D   $��0 0 5 0q�5,      .��6@   X6C   (  "System.Windows.Controls.WebBrowser  5-      -   5          Name$ 
WebBrowser��5-      $��1��6-   5.      �� 5/   
   -   5         ��Name$ NewMessageGrid��5/      $y�Visible=�6)   ���	#80afafaf$��1q�6V   	 �� CornerRadius$	 20 0 0 0��6j   $��2��50      $��2��6"   $��Right=�62   ���#FFFFFF$��Bottom=�6c   $��530px��6~   $	��350��6�   ._�51      � $��	15 15 0 0q�6    52      �� 53      $��45 �6$   �� 54      $��45 �6$   �� 55      $��45 �6$   �� 56      $��* �6$   .+�59      �� -   5        
 ��Name$
 AddressTextBox��59   .   $��
 0 5 160 0q�6F   $��16(�6Z   $��Center=�6h   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$% Адрес получателя��6�   ��6   �� *To+6�   �� 5:      -   5        $
 SubjectTextBox��5:   3   $��	 0 5 20 0q�6K   $��1��6^   $��16(�6k   $��Center=�6y   $ Тема��6�   ��6   �� *	Subject+6�   �� 5;      -   5        $ SendBtn��5;      $��Отправить��6*   $��80��6>   $��Right=�6I   $��0 0 50 0q�6e   #���  6w   {�5<      `� 5=       `� 	Converter# [  6'   .1�5>      ��  �� ElementName$ AddressTextBox��6&    �� Path$
 Text�6C   �� 5?      $ SubjectTextBox��6&   $
 Text�6C   5@      5B      �� 5C      -	   5        $ CloseNewMassageBtn��5C      #���  65   $��30��6a   
���  ��
�������$��Right=�6�   $��0 0 5 0q�6�   .��6�   X6�   �� 5D      $��40��6   $��2��6)    �� Orientation$ 
Horizontal=�66   .+�5E      d�   FormatToggleButtonStyle#���  6`    d� 	IsChecked 6#   �� *IsBold+��6@   �� *BoldCommand+.��5F      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 
FormatBold=�62   $
��20px��6D   $
��20px��6Q   $��Center=�5G   *   5H      d� 5I      #���  6d    6#   �� *
IsItalic+��6B   �� *ItalicCommand+.��5J        $ FormatItalic=�62   $
��20px��6F   $
��20px��6S   $��Center=�5K   *   5L      d� 5M      #���  6j    6#   �� *IsUnderline+��6E   �� *UnderlineCommand+.��5N        $ FormatUnderline=�62   $
��20px��6I   $
��20px��6V   $��Center=�5O   *   5P      �� 5Q      #���  6B   ��6   �� *LeftAlignCommand+.��5R        $ FormatAlignLeft=�62   $
��20px��6I   $
��20px��6V   $��Center=�6d   5S      �� 5T      #���  6D   ��6   �� *CenterAlignCommand+.��5U        $ FormatAlignCenter=�62   $
��20px��6K   $
��20px��6X   $��Center=�6f   5V      �� 5W      #���  6C   ��6   �� *RightAlignCommand+.��5X        $ FormatAlignRight=�62   $
��20px��6J   $
��20px��6W   $��Center=�6e   5Y      �� 5[      $��40 0 0 0q�6   $��18(�6.   $��Center=�6<   .��6^   
Font Size:6j   �� 5\      $��30��6   $��Center=�6b   $��18(�6�   ��6'   �� $ richTextBox��$ FontSize�6�   �� 5^      #���  6I   ��6   �� *IncreaseFontSizeCommand+.��5_        $ FormatFontSizeIncrease=�62   $
��20px��6P   $
��20px��6]   $��Center=�6k   5`      �� 5a      #���  6I   ��6   �� *DecreaseFontSizeCommand+.��5b        $ FormatFontSizeDecrease=�62   $
��20px��6P   $
��20px��6]   $��Center=�6k   5c      5e      �� 5f      -
   5         ��Name$ richTextBox��5f   +   $��3��6   6+   5g      5h      5i      5j      