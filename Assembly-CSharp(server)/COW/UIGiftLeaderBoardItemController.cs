using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200156D RID: 5485
	[Token(Token = "0x200156D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE8D4", Offset = "0x10EE8D4")]
	public class UIGiftLeaderBoardItemController : UIEasyListItemController
	{
		// Token: 0x06005F65 RID: 24421 RVA: 0x0001B990 File Offset: 0x00019B90
		[Token(Token = "0x6005F65")]
		[Address(RVA = "0x200FCDC", Offset = "0x200FCDC", VA = "0x7BBC80FCDC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005F66 RID: 24422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F66")]
		[Address(RVA = "0x200FD2C", Offset = "0x200FD2C", VA = "0x7BBC80FD2C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005F67 RID: 24423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F67")]
		[Address(RVA = "0x200FD90", Offset = "0x200FD90", VA = "0x7BBC80FD90", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005F68 RID: 24424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F68")]
		[Address(RVA = "0x200FD98", Offset = "0x200FD98", VA = "0x7BBC80FD98", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005F69 RID: 24425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F69")]
		[Address(RVA = "0x200FE70", Offset = "0x200FE70", VA = "0x7BBC80FE70")]
		private void RefreshView()
		{
		}

		// Token: 0x06005F6A RID: 24426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F6A")]
		[Address(RVA = "0x200F5A0", Offset = "0x200F5A0", VA = "0x7BBC80F5A0")]
		public void SetWidgetColor(Color color)
		{
		}

		// Token: 0x06005F6B RID: 24427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F6B")]
		[Address(RVA = "0x200F694", Offset = "0x200F694", VA = "0x7BBC80F694")]
		public void SetBgState(bool state)
		{
		}

		// Token: 0x06005F6C RID: 24428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F6C")]
		[Address(RVA = "0x200F68C", Offset = "0x200F68C", VA = "0x7BBC80F68C")]
		public void SetRankFormat(UIGiftLeaderBoardItemController.RankFormat format)
		{
		}

		// Token: 0x06005F6D RID: 24429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F6D")]
		[Address(RVA = "0x2010AB0", Offset = "0x2010AB0", VA = "0x7BBC810AB0")]
		public UIGiftLeaderBoardItemController()
		{
		}

		// Token: 0x04007FFE RID: 32766
		[Token(Token = "0x4007FFE")]
		[FieldOffset(Offset = "0x70")]
		private UIGiftLeaderBoardItemController.RankFormat m_RankFormat;

		// Token: 0x04007FFF RID: 32767
		[Token(Token = "0x4007FFF")]
		[FieldOffset(Offset = "0x78")]
		private UIGiftLeaderBoardItemView m_View;

		// Token: 0x04008000 RID: 32768
		[Token(Token = "0x4008000")]
		[FieldOffset(Offset = "0x80")]
		private CSSharedItemData m_ItemData;

		// Token: 0x04008001 RID: 32769
		[Token(Token = "0x4008001")]
		[FieldOffset(Offset = "0x88")]
		private LeaderBoardInfo m_Info;

		// Token: 0x04008002 RID: 32770
		[Token(Token = "0x4008002")]
		[FieldOffset(Offset = "0x90")]
		private UIBaseProfileInfoController m_BaseProfileUI;

		// Token: 0x04008003 RID: 32771
		[Token(Token = "0x4008003")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<uint, string> m_RankCupIcon;

		// Token: 0x04008004 RID: 32772
		[Token(Token = "0x4008004")]
		[FieldOffset(Offset = "0xA0")]
		private Dictionary<uint, float> m_BgAlpha;

		// Token: 0x0200156E RID: 5486
		[Token(Token = "0x200156E")]
		private enum ERewardState
		{
			// Token: 0x04008006 RID: 32774
			[Token(Token = "0x4008006")]
			None,
			// Token: 0x04008007 RID: 32775
			[Token(Token = "0x4008007")]
			UnClaimed,
			// Token: 0x04008008 RID: 32776
			[Token(Token = "0x4008008")]
			Claimed,
			// Token: 0x04008009 RID: 32777
			[Token(Token = "0x4008009")]
			Cant
		}

		// Token: 0x0200156F RID: 5487
		[Token(Token = "0x200156F")]
		public enum RankFormat
		{
			// Token: 0x0400800B RID: 32779
			[Token(Token = "0x400800B")]
			Normal,
			// Token: 0x0400800C RID: 32780
			[Token(Token = "0x400800C")]
			TopPercent
		}
	}
}
