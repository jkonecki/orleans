﻿namespace Orleans.LogViews
{
    /// <summary>
    ///  This interface encapsulates functionality of grains that want to host a log view adaptor.
    ///  It is the equivalent of <see cref="IStatefulGrain"/> for grains using log-view persistence.
    /// </summary>
    public interface ILogViewGrain 
    {
        /// <summary>
        /// called right after grain construction to install the log view adaptor 
        /// </summary>
        /// <param name="provider"> The log view provider to install </param>
        /// <param name="state"> The grain state to presist </param>
        /// <param name="grainTypeName"> The type of the grain </param>
        /// <param name="services"> Protocol services </param>
        void InstallAdaptor(ILogViewProvider provider, object state, string grainTypeName, IProtocolServices services);
    }

    /// <summary>
    /// Base class for all grains using a log view provider.
    /// It is the equivalent of <see cref="Grain{T}"/> for grains using log-view persistence.
    /// (SiloAssemblyLoader uses it to extract type)
    /// </summary>
    /// <typeparam name="TView">The type of the view</typeparam>
    public class LogViewGrainBase<TView> : Grain
    {
    }
}
