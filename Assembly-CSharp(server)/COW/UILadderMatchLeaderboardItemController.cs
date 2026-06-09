using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200152D RID: 5421
	[Token(Token = "0x200152D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE314", Offset = "0x10EE314")]
	internal class UILadderMatchLeaderboardItemController : UIEasyListItemController
	{
		// Token: 0x06005D63 RID: 23907 RVA: 0x0001B1E0 File Offset: 0x000193E0
		[Token(Token = "0x6005D63")]
		[Address(RVA = "0x1E88118", Offset = "0x1E88118", VA = "0x7BBC688118")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005D64 RID: 23908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D64")]
		[Address(RVA = "0x1E88168", Offset = "0x1E88168", VA = "0x7BBC688168", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005D65 RID: 23909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D65")]
		[Address(RVA = "0x1E88564", Offset = "0x1E88564", VA = "0x7BBC688564", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06005D66 RID: 23910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D66")]
		[Address(RVA = "0x1E88758", Offset = "0x1E88758", VA = "0x7BBC688758", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06005D67 RID: 23911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D67")]
		[Address(RVA = "0x1E87B3C", Offset = "0x1E87B3C", VA = "0x7BBC687B3C")]
		public void SetSelfUI(bool isRegion)
		{
		}

		// Token: 0x06005D68 RID: 23912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D68")]
		[Address(RVA = "0x1E88DB8", Offset = "0x1E88DB8", VA = "0x7BBC688DB8")]
		public UILadderMatchLeaderboardItemController()
		{
		}

		// Token: 0x04007F0B RID: 32523
		[Token(Token = "0x4007F0B")]
		[FieldOffset(Offset = "0x70")]
		private LadderMatchLeaderboardItemView m_View;

		// Token: 0x04007F0C RID: 32524
		[Token(Token = "0x4007F0C")]
		[FieldOffset(Offset = "0x78")]
		private LeaderBoardInfo m_Info;

		// Token: 0x04007F0D RID: 32525
		[Token(Token = "0x4007F0D")]
		[FieldOffset(Offset = "0x80")]
		private UIBaseProfileInfoController m_BaseProfile;

		// Token: 0x04007F0E RID: 32526
		[Token(Token = "0x4007F0E")]
		private const int m_TopRankThreshold = 3;

		// Token: 0x04007F0F RID: 32527
		[Token(Token = "0x4007F0F")]
		[FieldOffset(Offset = "0x88")]
		private GameObject[] m_TopCupArray;

		// Token: 0x04007F10 RID: 32528
		[Token(Token = "0x4007F10")]
		[FieldOffset(Offset = "0x90")]
		private GameObject[] m_TopBgArray;
	}
}
