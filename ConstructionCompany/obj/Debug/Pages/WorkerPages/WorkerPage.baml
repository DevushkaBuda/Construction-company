   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:ConstructionCompany.Pages.OrderPages$ConstructionCompany.Pages.OrderPages  5      6    0ConstructionCompany.Pages.WorkerPages.WorkerPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Dlocal2clr-namespace:ConstructionCompany.Pages.OrderPages     5      -   5          N� Title$  Worker��5      .��5      �  � RowDefinitions 5   
   �� 5      $��0.11* �6   �� 5      $��1* �6   .+�5   
   �� $$��Поиск по Фамилии��6   $��10,10,1000,10q�5      $��12(�5      $��Center=�5      �� 5   
   -   5         ��Name$ SearchSurName��5      $��14(�5      $��10,30,1000,10q�5      �� 5   
   -   5         ��Name$ 	Searchbut��5         jB#��[  5      ���	#FF9ACBF3$��
Поиск��5      $��14(�5      $��300,30,850,10q�5       5!      �� 5#   
   -   5        $ SearchClear��5#      #��[  5$      ���	#FF9ACBF3$��Очистить��5&      $��14(�5'      $��420,30,730,10q�5(      5)      �� 5+   
   -   5         ��Name$
 View��5+      
������ 
���   �$��20(�5.      $��1��5/       �� View 51      �� 52      .P�53      �� $��Фамилия��6%    �� Width$
 auto��54   %    �� DisplayMemberBinding 55   %   �� *	Surname+�� 56      $��Имя��6%   $
 auto��57   %    58   %   �� *Name+�� 59      $��Отчество��6%   $
 auto��5:   %    5;   %   �� *
Patronymic+�� 5<      $��Дата Рождения��6%   $
 auto��5=   %    5>   %   �� *	DateBirth+ �� StringFormat$ 
dd.MM.yyyy���� 5?      $��Телефон��6%   $
 auto��5@   %    5A   %   �� *	Telephone+�� 5B      $ ��Специальность��6%   $
 auto��5C   %    5D   %   �� *Expr1+5E      5G      �� 5H   
   -   5        $ Delete��5H      #��[  5I      ���	#FFC71F1F
������ $��Удалить��5L      $��24(�5M      $��1100,520,5,5q�5N      $��1��5P      5Q      5R      