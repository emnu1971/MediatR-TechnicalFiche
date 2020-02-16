namespace Mediator.Logic
{
    /// <summary>
    /// Author      : Emmanuel Nuyttens
    /// Date        : 02-2020
    /// Purpose     : Mediator notifier interface
    /// </summary>
    public interface INotifier
    {
        void Notify();
        bool CanRun();
    }
}
