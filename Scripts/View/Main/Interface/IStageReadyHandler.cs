using System;

namespace Lycoris102.Unity1Week202008.View.Main.Interface
{
    public interface IStageReadyHandler
    {
        IObservable<string> OnSetAnswerAsObservable();
    }
}