   M S B A M L   `   `   `  ����F  BTaskManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BankApplicationBankApplication  5   	        BankApplication.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:BankApplication     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  65     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $��Task Manager��6   $��Center=�6'   $��38��6D   $	��Top=�6P   $	��120��6h    J� RenderTransformOrigin$ 0.5,0.5&�6t   $��18(�6�   $��Bahnschrift Light)�6�   �� 5   
   -   5         ��Name$ AddUser��5      $��Create User��6O   $��Right=�6e   $��28��6�   $��	0,10,10,0q�6�   $��84��6�   $	 1,0&�6�   $	��Top=�6�   
����������	#FF2F2F2F$��Bahnschrift Light)�6
  ��6"   �� *ShowAddUserWindowCommand+6
  �� 5   
   -   5        $ 	ShowUsers��5      $��Show users list��6R   $��Right=�6l   $��28��6�   $��
0,10,110,0q�6�   $��97��6�   $	 1,0&�6�   $	��Top=�6�   
����������	#FF2F2F2F$��Bahnschrift Light)�6  ��6$   �� *ShowAllUsersWindowCommand+6  �� 5   
   -   5        $ AddTask��5      $��Create Task��6O   $��28��6e   $��
122,10,0,0q�6q   $	 1,0&�6�   $	��Top=�6�   
����������	#FF2F2F2F$
��Left=�6�   $��84��6�   $��Bahnschrift Light)�6
  ��6"   �� *ShowAddTaskWindowCommand+6
  �� 5   
   -   5         ��Name$ tasks��5      $��0,53,0,0q�6s   
���   ����	#FF112D77$��Bahnschrift Light)�6�    �� SelectedItem 6"   �� *selectedItem+ �� Mode$ TwoWay=���6U   �� *Tasks+ �� View 5      �� 5      .P�5      ��  �� Width$	 250��6%   $��Title��61    �� DisplayMemberBinding 6@   �� *Title+�� 5      $	 250��6%   $��Description��61    6F   �� *Description+5      .  (System.Windows.Interactivity.Interaction	   Triggers	 5      /  )System.Windows.Interactivity.EventTrigger  5      
   	EventName$
 MouseDoubleClick��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6,   �� *ShowTaskDetailsWindowCommand+5       � ContextMenu 5      �� 5      .@�5      m� $��Delete��6    m� Command 6/   �� *DeleteTaskCommand+5      5       5!      5"      