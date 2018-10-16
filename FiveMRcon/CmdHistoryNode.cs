namespace FiveMRcon
{
	public class CmdHistoryNode
	{
		public string Command;
		public CmdHistoryNode PreviousCmdNode { get; }
		public CmdHistoryNode NextCmdNode;

		public CmdHistoryNode(CmdHistoryNode prevNode)
		{
			PreviousCmdNode = prevNode;
		}
	}
}
