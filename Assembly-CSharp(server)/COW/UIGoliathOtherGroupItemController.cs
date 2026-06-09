using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001386 RID: 4998
	[Token(Token = "0x2001386")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB750", Offset = "0x10EB750")]
	public class UIGoliathOtherGroupItemController : UIBaseController, IGoliathGroupItem
	{
		// Token: 0x06005076 RID: 20598 RVA: 0x000186A8 File Offset: 0x000168A8
		[Token(Token = "0x6005076")]
		[Address(RVA = "0x1A7E4A8", Offset = "0x1A7E4A8", VA = "0x7BBC27E4A8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005077 RID: 20599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005077")]
		[Address(RVA = "0x1A7E4F8", Offset = "0x1A7E4F8", VA = "0x7BBC27E4F8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005078 RID: 20600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005078")]
		[Address(RVA = "0x1A7E7D8", Offset = "0x1A7E7D8", VA = "0x7BBC27E7D8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005079 RID: 20601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005079")]
		[Address(RVA = "0x1A7E7E0", Offset = "0x1A7E7E0", VA = "0x7BBC27E7E0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600507A RID: 20602 RVA: 0x000186C0 File Offset: 0x000168C0
		[Token(Token = "0x600507A")]
		[Address(RVA = "0x1A7E9A8", Offset = "0x1A7E9A8", VA = "0x7BBC27E9A8")]
		private UIGoliathOtherGroupItemController.ETaskOpenState GetTaskOpenState()
		{
			return UIGoliathOtherGroupItemController.ETaskOpenState.None;
		}

		// Token: 0x0600507B RID: 20603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600507B")]
		[Address(RVA = "0x1A79B00", Offset = "0x1A79B00", VA = "0x7BBC279B00")]
		public void SetViewData(GoliathAFKGroupInfo info)
		{
		}

		// Token: 0x0600507C RID: 20604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600507C")]
		[Address(RVA = "0x1A7EAB4", Offset = "0x1A7EAB4", VA = "0x7BBC27EAB4")]
		private void SetGroupOpenView()
		{
		}

		// Token: 0x0600507D RID: 20605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600507D")]
		[Address(RVA = "0x1A7F58C", Offset = "0x1A7F58C", VA = "0x7BBC27F58C")]
		private void SetGroupUnopenView()
		{
		}

		// Token: 0x0600507E RID: 20606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600507E")]
		[Address(RVA = "0x1A7F608", Offset = "0x1A7F608", VA = "0x7BBC27F608", Slot = "31")]
		public void SetGroupSelectView(bool isSelect)
		{
		}

		// Token: 0x0600507F RID: 20607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600507F")]
		[Address(RVA = "0x1A7F604", Offset = "0x1A7F604", VA = "0x7BBC27F604")]
		private void SetGroupErrorView()
		{
		}

		// Token: 0x06005080 RID: 20608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005080")]
		[Address(RVA = "0x1A7F690", Offset = "0x1A7F690", VA = "0x7BBC27F690")]
		private void OnBtnGroupFinishedClick()
		{
		}

		// Token: 0x06005081 RID: 20609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005081")]
		[Address(RVA = "0x1A7F888", Offset = "0x1A7F888", VA = "0x7BBC27F888")]
		private void OnBtnJoinGroupClick()
		{
		}

		// Token: 0x06005082 RID: 20610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005082")]
		[Address(RVA = "0x1A7FA5C", Offset = "0x1A7FA5C", VA = "0x7BBC27FA5C")]
		private void OnBtnCopyGroupIDClick()
		{
		}

		// Token: 0x06005083 RID: 20611 RVA: 0x000186D8 File Offset: 0x000168D8
		[Token(Token = "0x6005083")]
		[Address(RVA = "0x1A7FCAC", Offset = "0x1A7FCAC", VA = "0x7BBC27FCAC", Slot = "30")]
		public ulong GetGroupId()
		{
			return 0UL;
		}

		// Token: 0x06005084 RID: 20612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005084")]
		[Address(RVA = "0x1A7FCC4", Offset = "0x1A7FCC4", VA = "0x7BBC27FCC4", Slot = "28")]
		public GoliathAFKGroupInfo GetItemInfo()
		{
			return null;
		}

		// Token: 0x06005085 RID: 20613 RVA: 0x000186F0 File Offset: 0x000168F0
		[Token(Token = "0x6005085")]
		[Address(RVA = "0x1A79BE4", Offset = "0x1A79BE4", VA = "0x7BBC279BE4", Slot = "29")]
		public int GetItemIndex()
		{
			return 0;
		}

		// Token: 0x06005086 RID: 20614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005086")]
		[Address(RVA = "0x1A7746C", Offset = "0x1A7746C", VA = "0x7BBC27746C")]
		public void SetItemIndex(int newIndex)
		{
		}

		// Token: 0x06005087 RID: 20615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005087")]
		[Address(RVA = "0x1A7FCCC", Offset = "0x1A7FCCC", VA = "0x7BBC27FCCC")]
		public UIGoliathOtherGroupItemController()
		{
		}

		// Token: 0x06005088 RID: 20616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005088")]
		[Address(RVA = "0x1A7FCD4", Offset = "0x1A7FCD4", VA = "0x7BBC27FCD4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DFEC", Offset = "0x113DFEC")]
		private void <OnUIInit>b__11_0()
		{
		}

		// Token: 0x040076F5 RID: 30453
		[Token(Token = "0x40076F5")]
		[FieldOffset(Offset = "0x58")]
		private UIGoliathOtherGroupItemView m_View;

		// Token: 0x040076F6 RID: 30454
		[Token(Token = "0x40076F6")]
		[FieldOffset(Offset = "0x60")]
		private UIModelBigEvent m_ModelBigEvent;

		// Token: 0x040076F7 RID: 30455
		[Token(Token = "0x40076F7")]
		[FieldOffset(Offset = "0x68")]
		private UIModelGoliath m_ModelGoliath;

		// Token: 0x040076F8 RID: 30456
		[Token(Token = "0x40076F8")]
		[FieldOffset(Offset = "0x70")]
		private GoliathAFKGroupInfo m_Info;

		// Token: 0x040076F9 RID: 30457
		[Token(Token = "0x40076F9")]
		[FieldOffset(Offset = "0x78")]
		private int m_ItemIndex;

		// Token: 0x040076FA RID: 30458
		[Token(Token = "0x40076FA")]
		[FieldOffset(Offset = "0x80")]
		private ulong m_StartTime;

		// Token: 0x040076FB RID: 30459
		[Token(Token = "0x40076FB")]
		[FieldOffset(Offset = "0x88")]
		private ulong m_EndTime;

		// Token: 0x040076FC RID: 30460
		[Token(Token = "0x40076FC")]
		[FieldOffset(Offset = "0x90")]
		private UIStandardItemMiniController m_AFKAwardCtrl;

		// Token: 0x040076FD RID: 30461
		[Token(Token = "0x40076FD")]
		[FieldOffset(Offset = "0x98")]
		private UIGoliathOtherGroupItemController.ETaskOpenState m_TaskOpenState;

		// Token: 0x02001387 RID: 4999
		[Token(Token = "0x2001387")]
		public enum ETaskOpenState
		{
			// Token: 0x040076FF RID: 30463
			[Token(Token = "0x40076FF")]
			None,
			// Token: 0x04007700 RID: 30464
			[Token(Token = "0x4007700")]
			WaitForStart,
			// Token: 0x04007701 RID: 30465
			[Token(Token = "0x4007701")]
			InProgress,
			// Token: 0x04007702 RID: 30466
			[Token(Token = "0x4007702")]
			Finished
		}
	}
}
