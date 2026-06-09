using System;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001460 RID: 5216
	[Token(Token = "0x2001460")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ECC30", Offset = "0x10ECC30")]
	public class BountyRepairingRankController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x060057B0 RID: 22448 RVA: 0x00019F08 File Offset: 0x00018108
		[Token(Token = "0x60057B0")]
		[Address(RVA = "0x14E5560", Offset = "0x14E5560", VA = "0x7BBBCE5560")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060057B1 RID: 22449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B1")]
		[Address(RVA = "0x14E55B0", Offset = "0x14E55B0", VA = "0x7BBBCE55B0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060057B2 RID: 22450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B2")]
		[Address(RVA = "0x14E58F4", Offset = "0x14E58F4", VA = "0x7BBBCE58F4")]
		private void InitItemContent(BountyRepairingItem item)
		{
		}

		// Token: 0x060057B3 RID: 22451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B3")]
		[Address(RVA = "0x14E59C0", Offset = "0x14E59C0", VA = "0x7BBBCE59C0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060057B4 RID: 22452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B4")]
		[Address(RVA = "0x14E5AAC", Offset = "0x14E5AAC", VA = "0x7BBBCE5AAC")]
		private void OnRepairRankChange(params object[] param)
		{
		}

		// Token: 0x060057B5 RID: 22453 RVA: 0x00019F20 File Offset: 0x00018120
		[Token(Token = "0x60057B5")]
		[Address(RVA = "0x14E5D90", Offset = "0x14E5D90", VA = "0x7BBBCE5D90", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060057B6 RID: 22454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B6")]
		[Address(RVA = "0x14E5DD4", Offset = "0x14E5DD4", VA = "0x7BBBCE5DD4", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060057B7 RID: 22455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B7")]
		[Address(RVA = "0x14E5E7C", Offset = "0x14E5E7C", VA = "0x7BBBCE5E7C")]
		public void LockTeleportMachine()
		{
		}

		// Token: 0x060057B8 RID: 22456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B8")]
		[Address(RVA = "0x14E5F58", Offset = "0x14E5F58", VA = "0x7BBBCE5F58")]
		public BountyRepairingRankController()
		{
		}

		// Token: 0x04007BDB RID: 31707
		[Token(Token = "0x4007BDB")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDBountyRepairRankView m_View;

		// Token: 0x04007BDC RID: 31708
		[Token(Token = "0x4007BDC")]
		[FieldOffset(Offset = "0x60")]
		private uint localPlayerPoint;

		// Token: 0x04007BDD RID: 31709
		[Token(Token = "0x4007BDD")]
		[FieldOffset(Offset = "0x64")]
		private |l\u007Fz\u0081JY m_CurTeleportMachineState;

		// Token: 0x04007BDE RID: 31710
		[Token(Token = "0x4007BDE")]
		[FieldOffset(Offset = "0x68")]
		private UIModelMatch m_MatchModel;

		// Token: 0x04007BDF RID: 31711
		[Token(Token = "0x4007BDF")]
		[FieldOffset(Offset = "0x70")]
		private bool m_IsLockRepair;
	}
}
