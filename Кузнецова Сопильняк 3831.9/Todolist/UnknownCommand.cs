namespace TodoList
{
    class UnknownCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Неизвестная команда. Введите 'help' для просмотра доступных команд.");
        }
    }
}