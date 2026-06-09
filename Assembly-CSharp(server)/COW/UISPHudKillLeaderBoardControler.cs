using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B91 RID: 7057
	[Token(Token = "0x2001B91")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA644", Offset = "0x10FA644")]
	internal class UISPHudKillLeaderBoardControler : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06009838 RID: 38968 RVA: 0x00028158 File Offset: 0x00026358
		[Token(Token = "0x6009838")]
		[Address(RVA = "0x1EE8544", Offset = "0x1EE8544", VA = "0x7BBC6E8544")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009839 RID: 38969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009839")]
		[Address(RVA = "0x1EE8594", Offset = "0x1EE8594", VA = "0x7BBC6E8594", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600983A RID: 38970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600983A")]
		[Address(RVA = "0x1EE8714", Offset = "0x1EE8714", VA = "0x7BBC6E8714", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x0600983B RID: 38971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600983B")]
		[Address(RVA = "0x1EE8754", Offset = "0x1EE8754", VA = "0x7BBC6E8754", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600983C RID: 38972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600983C")]
		[Address(RVA = "0x1EE8814", Offset = "0x1EE8814", VA = "0x7BBC6E8814")]
		public void SetKillLeaderBoardInfo(SPGameAchievement achievement)
		{
		}

		// Token: 0x0600983D RID: 38973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600983D")]
		[Address(RVA = "0x1EE8B24", Offset = "0x1EE8B24", VA = "0x7BBC6E8B24")]
		private void OnUIToggle(params object[] data)
		{
		}

		// Token: 0x0600983E RID: 38974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600983E")]
		[Address(RVA = "0x1EE8BC4", Offset = "0x1EE8BC4", VA = "0x7BBC6E8BC4", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600983F RID: 38975 RVA: 0x00028170 File Offset: 0x00026370
		[Token(Token = "0x600983F")]
		[Address(RVA = "0x1EE8EC4", Offset = "0x1EE8EC4", VA = "0x7BBC6E8EC4", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009840 RID: 38976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009840")]
		[Address(RVA = "0x1EE8F08", Offset = "0x1EE8F08", VA = "0x7BBC6E8F08")]
		public UISPHudKillLeaderBoardControler()
		{
		}

		// Token: 0x0400A025 RID: 40997
		[Token(Token = "0x400A025")]
		[FieldOffset(Offset = "0x58")]
		private UISPHudKillLeaderBoardView m_View;

		// Token: 0x0400A026 RID: 40998
		[Token(Token = "0x400A026")]
		[FieldOffset(Offset = "0x60")]
		private UIModelSpectator m_model;

		// Token: 0x0400A027 RID: 40999
		[Token(Token = "0x400A027")]
		[FieldOffset(Offset = "0x68")]
		private bool HasKillLeader;
	}
}
