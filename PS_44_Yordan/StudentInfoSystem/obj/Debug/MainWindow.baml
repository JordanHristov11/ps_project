   M S B A M L   `   `   `  ����L  HStudentInfoSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:StudentInfoSystemStudentInfoSystem  5   	   "    StudentInfoSystem.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:StudentInfoSystem     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5         �Name$ MainGrid��5	      .+�5
   
   �� -   5         ��Name$ ___Welcome_��5
      $��Center=�6)   $��0,28,0,0q�6F   $
��Wrap=�6X   $��Welcome!��6l   $	��Top=�6|   $��36��6�   $	��190��6�   $��20(�6�   $
��Bold"�6�    �� TextAlignment$ Center=�6�   �� 5   
   -   5         ��Name$ ___btnLogin_��5      $��Login��6'   $
��Left=�67   $��
95,217,0,0q�6R   $	��Top=�6f   $��31��6~   $��98��6�   6�   �� 5   
   -   5         ��Name$ lblName��5      $��Име��6!   $
��Left=�6/   $��
87,184,0,0q�6J   $	��Top=�6^   $��23��6v   $��57��6�   �� 5   
   -   5         ��Name$ txtBox��5      $
��Left=�6"   $��149,184,0,0q�6=    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $	��104��6~   $��23��6�   4  .System.Windows.Automation.AutomationProperties   IsRequiredForForm . 6�   �� 5   
   -   5        	 ��Name$	 groupBoxStudent��5      $��Student Info:��6,   $��416,64,36,39q�6C   $��Visible=�6Y   $��Stretch=�6�   $��Center=�6�   .��5      � $��	10,0,-2,1q�6   .+�5      �� -   5        $ ___txtBoxName_��5      $��Center=�64   $��0,23,0,0q�6Q   $
��Wrap=�6c   $	��Top=�6w   $	��146��6�   �� 5      -   5        $ txtBoxSecondName��5      $��Center=�66   $��0,53,0,0q�6S   $
��Wrap=�6e   $	��Top=�6y   $	��146��6�   �� 5      -	   5        $ txtBoxFamiliyName��5      $��Center=�67   $��0,85,0,0q�6T   $
��Wrap=�6f   $	��Top=�6z   $	��146��6�   �� 5      -
   5        $ txtBoxFaculty��5      $��Center=�63   $��	0,114,0,0q�6P   $
��Wrap=�6c   $	��Top=�6w   $	��146��6�   �� 5      $��Center=�6   $��	0,138,0,0q�69   $
��Wrap=�6L   $��	TextBlock��6`   $	��Top=�6q   $	��146��6�   �� 5      $��Center=�6   $��	0,162,0,0q�69   $
��Wrap=�6L   $��	TextBlock��6`   $	��Top=�6q   $	��146��6�   �� 5      $��Center=�6   $��	0,183,0,0q�69   $
��Wrap=�6L   $��	TextBlock��6`   $	��Top=�6q   $	��146��6�   �� 5      $��Center=�6   $��	0,204,0,0q�69   $
��Wrap=�6L   $��	TextBlock��6`   $	��Top=�6q   $	��146��6�   �� 5      $��Center=�6   $��	0,225,0,0q�69   $
��Wrap=�6L   $��	TextBlock��6`   $	��Top=�6q   $	��146��6�   �� 5      $��Center=�6   $��	0,246,0,0q�69   $
��Wrap=�6L   $��	TextBlock��6`   $	��Top=�6q   $	��146��6�   � 5      5      5      �� 5   
   -   5        $��Logout��5      $
��Left=�6"   $��
95,321,0,0q�6=   $	��Top=�6Q   $��30��6i   $��97��6u   6�   �� 5   
   $��272,110,400,217q�6<   ��6   �� *StudStatusChoices+6<   �� 5   
   -   5        $��Button��5      $
��Left=�6"   $��292,351,0,0q�6=   $	��Top=�6R   6j   5"      5#      