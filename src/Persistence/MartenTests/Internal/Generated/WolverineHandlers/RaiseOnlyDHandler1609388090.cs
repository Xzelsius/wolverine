// <auto-generated/>
#pragma warning disable
using Wolverine.Marten.Publishing;

namespace Internal.Generated.WolverineHandlers
{
    // START: RaiseOnlyDHandler1609388090
    public class RaiseOnlyDHandler1609388090 : Wolverine.Runtime.Handlers.MessageHandler
    {
        private readonly Wolverine.Marten.Publishing.OutboxedSessionFactory _outboxedSessionFactory;

        public RaiseOnlyDHandler1609388090(Wolverine.Marten.Publishing.OutboxedSessionFactory outboxedSessionFactory)
        {
            _outboxedSessionFactory = outboxedSessionFactory;
        }

        public override async System.Threading.Tasks.Task HandleAsync(Wolverine.Runtime.MessageContext context, System.Threading.CancellationToken cancellation)
        {
            // The actual message body
            var raiseOnlyD = (MartenTests.RaiseOnlyD)context.Envelope.Message;

            await using var documentSession = _outboxedSessionFactory.OpenSession(context);
            var eventStore = documentSession.Events;
            
            // Loading Marten aggregate
            var eventStream = await eventStore.FetchForWriting<MartenTests.LetterAggregate>(raiseOnlyD.LetterAggregateId, cancellation).ConfigureAwait(false);

            
            // The actual message execution
            var outgoing1 = MartenTests.RaiseLetterHandler.Handle(raiseOnlyD, eventStream.Aggregate);

            eventStream.AppendOne(outgoing1);
            await documentSession.SaveChangesAsync(cancellation).ConfigureAwait(false);
        }
    }

    // END: RaiseOnlyDHandler1609388090
    
    
}