   M S B A M L   `   `   `  ����   
WpfExample    WpfExample.NamesWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Commanding Demo��$	��250��$	��300��.���  � ColumnDefinitions �� $
��Auto ���  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� �� $
��Auto �.+��� .��
First Name�� $��1������ *	FirstName+ �� UpdateSourceTrigger$ PropertyChanged=��� $��1��.��	Last Name�� $��1��$��1������ *
LastName+$ PropertyChanged=��� $��2��$��2�� �� Orientation$ 
Horizontal=�$��Right=�.+��� ���� *AddNameCommand+���� *.+.��Add�� ���� *RemoveNameCommand+���� *.+.��Remove�� $��3��.��Names�� $��1��$��3��$	��5 0q�
����������� *Names+ �� SelectedItem �� *SelectedName+�� $��2��$��4��.��Info