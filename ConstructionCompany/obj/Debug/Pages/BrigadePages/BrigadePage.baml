   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:ConstructionCompany.Pages.BrigadePages&ConstructionCompany.Pages.BrigadePages  5      8    2ConstructionCompany.Pages.BrigadePages.BrigadePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Flocal4clr-namespace:ConstructionCompany.Pages.BrigadePages     5      -   5          N� Title$  Brigade��5      .��5      �  � RowDefinitions 5   
   �� 5      $��0.11* �6   �� 5      $��1* �6   .+�5   
   �� $5��/Поиск по Названию бригады��6   $��10,10,1000,10q�5      $��12(�5      $��Center=�5      �� 5   
   -   5         ��Name$ 
SearchName��5      $��14(�5      $��10,30,1000,10q�5      �� 5   
   $(��"Поиск по бригадиру��6   $��300,10,700,10q�5      $��12(�5      $��Center=�5      �� 5   
   -   5        $ 
SearchBrig��5      $��12(�5      $��300,30,700,10q�5       �� 5"   
   -   5         ��Name$ 	Searchbut��5"         jB#��[  5#      ���	#FF9ACBF3$��
Поиск��5%      $��14(�5&      $��600,30,550,10q�5'      5(      �� 5*   
   -   5        $ SearchClear��5*      #��[  5+      ���	#FF9ACBF3$��Очистить��5-      $��14(�5.      $��720,30,430,10q�5/      50      �� 51   
   -   5         ��Name$
 View��51      
������ 
���   �$��20(�54      $��1��55       �� View 57      �� 58      .P�59      �� $%��Название бригады��6%    �� Width$
 auto��5:   %    �� DisplayMemberBinding 5;   %   �� *Name+�� 5<      $��Бригадир��6%   $
 auto��5=   %    5>   %   �� *	Brigadier+�� 5?      $��Рабочие��6%   $
 auto��5@   %    5A   %   �� *Worker+5B      5D      �� 5E   
   -   5        $ Delete��5E      #��[  5F      ���	#FFC71F1F
������ $��Удалить��5I      $��24(�5J      $��1100,520,5,5q�5K      $��1��5L   &   5M      5N      