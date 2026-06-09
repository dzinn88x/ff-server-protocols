using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001379 RID: 4985
	[Token(Token = "0x2001379")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB608", Offset = "0x10EB608")]
	public class UIGoliathGroupItemController : UIBaseController, IGoliathGroupItem
	{
		// Token: 0x06004FFE RID: 20478 RVA: 0x00018540 File Offset: 0x00016740
		[Token(Token = "0x6004FFE")]
		[Address(RVA = "0x1A6F4E0", Offset = "0x1A6F4E0", VA = "0x7BBC26F4E0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06004FFF RID: 20479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FFF")]
		[Address(RVA = "0x1A6F530", Offset = "0x1A6F530", VA = "0x7BBC26F530", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005000 RID: 20480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005000")]
		[Address(RVA = "0x1A6F948", Offset = "0x1A6F948", VA = "0x7BBC26F948", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005001 RID: 20481 RVA: 0x00018558 File Offset: 0x00016758
		[Token(Token = "0x6005001")]
		[Address(RVA = "0x1A6F950", Offset = "0x1A6F950", VA = "0x7BBC26F950")]
		public UIGoliathGroupItemController.ETaskOpenState GetTaskOpenState()
		{
			return UIGoliathGroupItemController.ETaskOpenState.None;
		}

		// Token: 0x06005002 RID: 20482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005002")]
		[Address(RVA = "0x1A6FA5C", Offset = "0x1A6FA5C", VA = "0x7BBC26FA5C")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06005003 RID: 20483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005003")]
		[Address(RVA = "0x1A70BC4", Offset = "0x1A70BC4", VA = "0x7BBC270BC4")]
		public void SetViewData(GoliathAFKGroupInfo info)
		{
		}

		// Token: 0x06005004 RID: 20484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005004")]
		[Address(RVA = "0x1A6FC2C", Offset = "0x1A6FC2C", VA = "0x7BBC26FC2C")]
		private void SetGroupOpenView()
		{
		}

		// Token: 0x06005005 RID: 20485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005005")]
		[Address(RVA = "0x1A70CC8", Offset = "0x1A70CC8", VA = "0x7BBC270CC8")]
		private void SetGroupUnopenView()
		{
		}

		// Token: 0x06005006 RID: 20486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005006")]
		[Address(RVA = "0x1A70D40", Offset = "0x1A70D40", VA = "0x7BBC270D40")]
		private void SetGroupErrorView()
		{
		}

		// Token: 0x06005007 RID: 20487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005007")]
		[Address(RVA = "0x1A705F8", Offset = "0x1A705F8", VA = "0x7BBC2705F8")]
		public void SetActivityView()
		{
		}

		// Token: 0x06005008 RID: 20488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005008")]
		[Address(RVA = "0x1A70D44", Offset = "0x1A70D44", VA = "0x7BBC270D44")]
		private void SetActivityErrorView()
		{
		}

		// Token: 0x06005009 RID: 20489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005009")]
		[Address(RVA = "0x1A70D48", Offset = "0x1A70D48", VA = "0x7BBC270D48", Slot = "31")]
		public void SetGroupSelectView(bool isSelect)
		{
		}

		// Token: 0x0600500A RID: 20490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600500A")]
		[Address(RVA = "0x1A70DD0", Offset = "0x1A70DD0", VA = "0x7BBC270DD0")]
		public void OnBtnCreateGroupClick()
		{
		}

		// Token: 0x0600500B RID: 20491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600500B")]
		[Address(RVA = "0x1A70F78", Offset = "0x1A70F78", VA = "0x7BBC270F78")]
		private void OnBtnOpenActivityClick()
		{
		}

		// Token: 0x0600500C RID: 20492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600500C")]
		[Address(RVA = "0x1A70FD8", Offset = "0x1A70FD8", VA = "0x7BBC270FD8")]
		private void OnBtnGroupFinishedClick()
		{
		}

		// Token: 0x0600500D RID: 20493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600500D")]
		[Address(RVA = "0x1A711D0", Offset = "0x1A711D0", VA = "0x7BBC2711D0")]
		private void OnBtnActivityFinishedClick()
		{
		}

		// Token: 0x0600500E RID: 20494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600500E")]
		[Address(RVA = "0x1A7122C", Offset = "0x1A7122C", VA = "0x7BBC27122C")]
		private void OnBtnCopyGroupIDClick()
		{
		}

		// Token: 0x0600500F RID: 20495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600500F")]
		[Address(RVA = "0x1A7147C", Offset = "0x1A7147C", VA = "0x7BBC27147C", Slot = "28")]
		public GoliathAFKGroupInfo GetItemInfo()
		{
			return null;
		}

		// Token: 0x06005010 RID: 20496 RVA: 0x00018570 File Offset: 0x00016770
		[Token(Token = "0x6005010")]
		[Address(RVA = "0x1A71484", Offset = "0x1A71484", VA = "0x7BBC271484", Slot = "30")]
		public ulong GetGroupId()
		{
			return 0UL;
		}

		// Token: 0x06005011 RID: 20497 RVA: 0x00018588 File Offset: 0x00016788
		[Token(Token = "0x6005011")]
		[Address(RVA = "0x1A7149C", Offset = "0x1A7149C", VA = "0x7BBC27149C", Slot = "29")]
		public int GetItemIndex()
		{
			return 0;
		}

		// Token: 0x06005012 RID: 20498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005012")]
		[Address(RVA = "0x1A714A4", Offset = "0x1A714A4", VA = "0x7BBC2714A4")]
		public void SetItemIndex(int newIndex)
		{
		}

		// Token: 0x06005013 RID: 20499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005013")]
		[Address(RVA = "0x1A714AC", Offset = "0x1A714AC", VA = "0x7BBC2714AC")]
		public UIWidget GetBtnCreateWidget()
		{
			return null;
		}

		// Token: 0x06005014 RID: 20500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005014")]
		[Address(RVA = "0x1A7151C", Offset = "0x1A7151C", VA = "0x7BBC27151C")]
		public UIWidget GetCreateGuideRegion()
		{
			return null;
		}

		// Token: 0x06005015 RID: 20501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005015")]
		[Address(RVA = "0x1A71548", Offset = "0x1A71548", VA = "0x7BBC271548")]
		public UIWidget GetCopyGuideRegion()
		{
			return null;
		}

		// Token: 0x06005016 RID: 20502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005016")]
		[Address(RVA = "0x1A71574", Offset = "0x1A71574", VA = "0x7BBC271574")]
		public UIGoliathGroupItemController()
		{
		}

		// Token: 0x06005017 RID: 20503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005017")]
		[Address(RVA = "0x1A7157C", Offset = "0x1A7157C", VA = "0x7BBC27157C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DFAC", Offset = "0x113DFAC")]
		private void <OnUIInit>b__15_0()
		{
		}

		// Token: 0x04007693 RID: 30355
		[Token(Token = "0x4007693")]
		[FieldOffset(Offset = "0x58")]
		private UIGoliathGroupItemView m_View;

		// Token: 0x04007694 RID: 30356
		[Token(Token = "0x4007694")]
		[FieldOffset(Offset = "0x60")]
		private UIModelBigEvent m_ModelBigEvent;

		// Token: 0x04007695 RID: 30357
		[Token(Token = "0x4007695")]
		[FieldOffset(Offset = "0x68")]
		private UIModelGoliath m_ModelGoliath;

		// Token: 0x04007696 RID: 30358
		[Token(Token = "0x4007696")]
		[FieldOffset(Offset = "0x70")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x04007697 RID: 30359
		[Token(Token = "0x4007697")]
		[FieldOffset(Offset = "0x78")]
		private GoliathAFKGroupInfo m_Info;

		// Token: 0x04007698 RID: 30360
		[Token(Token = "0x4007698")]
		[FieldOffset(Offset = "0x80")]
		private int m_ItemIndex;

		// Token: 0x04007699 RID: 30361
		[Token(Token = "0x4007699")]
		[FieldOffset(Offset = "0x88")]
		private UIStandardItemMiniController m_AFKAwardCtrl;

		// Token: 0x0400769A RID: 30362
		[Token(Token = "0x400769A")]
		[FieldOffset(Offset = "0x90")]
		private UIStandardItemMiniController m_ActivityAwardCtrl;

		// Token: 0x0400769B RID: 30363
		[Token(Token = "0x400769B")]
		public const uint COLOR_CAPTAIN_ACTIVITY_UNFINISHED = 3906258431U;

		// Token: 0x0400769C RID: 30364
		[Token(Token = "0x400769C")]
		public const uint COLOR_CAPTAIN_ACTIVITY_FINISHED = 4290576639U;

		// Token: 0x0400769D RID: 30365
		[Token(Token = "0x400769D")]
		[FieldOffset(Offset = "0x98")]
		private ulong m_StartTime;

		// Token: 0x0400769E RID: 30366
		[Token(Token = "0x400769E")]
		[FieldOffset(Offset = "0xA0")]
		private ulong m_EndTime;

		// Token: 0x0400769F RID: 30367
		[Token(Token = "0x400769F")]
		[FieldOffset(Offset = "0xA8")]
		private UIGoliathGroupItemController.ETaskOpenState m_TaskOpenState;

		// Token: 0x0200137A RID: 4986
		[Token(Token = "0x200137A")]
		public enum ETaskOpenState
		{
			// Token: 0x040076A1 RID: 30369
			[Token(Token = "0x40076A1")]
			None,
			// Token: 0x040076A2 RID: 30370
			[Token(Token = "0x40076A2")]
			WaitForStart,
			// Token: 0x040076A3 RID: 30371
			[Token(Token = "0x40076A3")]
			InProgress,
			// Token: 0x040076A4 RID: 30372
			[Token(Token = "0x40076A4")]
			Finished
		}
	}
}
