using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020015F6 RID: 5622
	[Token(Token = "0x20015F6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF75C", Offset = "0x10EF75C")]
	internal class UIHudSingleFightMatchResultController : UIHudMatchResultBaseController, IEasyList
	{
		// Token: 0x06006435 RID: 25653 RVA: 0x0001CCB0 File Offset: 0x0001AEB0
		[Token(Token = "0x6006435")]
		[Address(RVA = "0x1665650", Offset = "0x1665650", VA = "0x7BBBE65650")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06006436 RID: 25654 RVA: 0x0001CCC8 File Offset: 0x0001AEC8
		[Token(Token = "0x170008F8")]
		public int LocalPlayerItemIndex
		{
			[Token(Token = "0x6006436")]
			[Address(RVA = "0x16656A0", Offset = "0x16656A0", VA = "0x7BBBE656A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06006437 RID: 25655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006437")]
		[Address(RVA = "0x16656A8", Offset = "0x16656A8", VA = "0x7BBBE656A8")]
		public UIHudSingleFightMatchResultController()
		{
		}

		// Token: 0x06006438 RID: 25656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006438")]
		[Address(RVA = "0x16656DC", Offset = "0x16656DC", VA = "0x7BBBE656DC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006439 RID: 25657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006439")]
		[Address(RVA = "0x1665BAC", Offset = "0x1665BAC", VA = "0x7BBBE65BAC", Slot = "45")]
		protected override void OnShowAvatarInfoUI()
		{
		}

		// Token: 0x0600643A RID: 25658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600643A")]
		[Address(RVA = "0x1665C48", Offset = "0x1665C48", VA = "0x7BBBE65C48", Slot = "44")]
		protected override void OnShowMatchResultDetailUI(bool show)
		{
		}

		// Token: 0x0600643B RID: 25659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600643B")]
		[Address(RVA = "0x1665E08", Offset = "0x1665E08", VA = "0x7BBBE65E08", Slot = "43")]
		protected override void OnSetMatchResultInfo(MatchStats stats)
		{
		}

		// Token: 0x0600643C RID: 25660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600643C")]
		[Address(RVA = "0x166653C", Offset = "0x166653C", VA = "0x7BBBE6653C", Slot = "42")]
		protected override EMatchResultPlayerInfoType[] GetInfoTypes()
		{
			return null;
		}

		// Token: 0x0600643D RID: 25661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600643D")]
		[Address(RVA = "0x16665A8", Offset = "0x16665A8", VA = "0x7BBBE665A8", Slot = "46")]
		protected override void OnUpdate(float delta)
		{
		}

		// Token: 0x0600643E RID: 25662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600643E")]
		[Address(RVA = "0x1666780", Offset = "0x1666780", VA = "0x7BBBE66780", Slot = "47")]
		protected override List<PlayerData> CreateShowAvatarPlayerData()
		{
			return null;
		}

		// Token: 0x0600643F RID: 25663 RVA: 0x0001CCE0 File Offset: 0x0001AEE0
		[Token(Token = "0x600643F")]
		[Address(RVA = "0x1666BC0", Offset = "0x1666BC0", VA = "0x7BBBE66BC0", Slot = "40")]
		protected override int SortPlayerData(PlayerData player1, PlayerData player2)
		{
			return 0;
		}

		// Token: 0x06006440 RID: 25664 RVA: 0x0001CCF8 File Offset: 0x0001AEF8
		[Token(Token = "0x6006440")]
		[Address(RVA = "0x1666C08", Offset = "0x1666C08", VA = "0x7BBBE66C08", Slot = "48")]
		protected override bool CheckIsWin(MatchStats stats)
		{
			return default(bool);
		}

		// Token: 0x06006441 RID: 25665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006441")]
		[Address(RVA = "0x1666C10", Offset = "0x1666C10", VA = "0x7BBBE66C10", Slot = "49")]
		protected override void OnFixMatchInfoForLanguage()
		{
		}

		// Token: 0x06006442 RID: 25666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006442")]
		[Address(RVA = "0x1666238", Offset = "0x1666238", VA = "0x7BBBE66238")]
		private void UpdatePlayerListInfo(List<TeammateStats> players, ulong localplayerID)
		{
		}

		// Token: 0x06006443 RID: 25667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006443")]
		[Address(RVA = "0x1666CE4", Offset = "0x1666CE4", VA = "0x7BBBE66CE4", Slot = "50")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06006444 RID: 25668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006444")]
		[Address(RVA = "0x1666E5C", Offset = "0x1666E5C", VA = "0x7BBBE66E5C", Slot = "51")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x040082D2 RID: 33490
		[Token(Token = "0x40082D2")]
		[FieldOffset(Offset = "0x210")]
		private UIHudSingleFightMatchResultView m_View;

		// Token: 0x040082D3 RID: 33491
		[Token(Token = "0x40082D3")]
		[FieldOffset(Offset = "0x218")]
		private UIHudSingleFightMatchResultItemController m_SelfUIItem;

		// Token: 0x040082D4 RID: 33492
		[Token(Token = "0x40082D4")]
		[FieldOffset(Offset = "0x220")]
		private int m_LocalPlayerItemIndex;

		// Token: 0x040082D5 RID: 33493
		[Token(Token = "0x40082D5")]
		private const int ShowSelfItemRank = 4;

		// Token: 0x040082D6 RID: 33494
		[Token(Token = "0x40082D6")]
		private const int ShowAvatarPlayerRank = 3;

		// Token: 0x020015F7 RID: 5623
		[Token(Token = "0x20015F7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EF794", Offset = "0x10EF794")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006446 RID: 25670 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006446")]
			[Address(RVA = "0x1666EF0", Offset = "0x1666EF0", VA = "0x7BBBE66EF0")]
			public <>c()
			{
			}

			// Token: 0x06006447 RID: 25671 RVA: 0x0001CD10 File Offset: 0x0001AF10
			[Token(Token = "0x6006447")]
			[Address(RVA = "0x1666EF8", Offset = "0x1666EF8", VA = "0x7BBBE66EF8")]
			internal int <UpdatePlayerListInfo>b__19_0(TeammateStats a, TeammateStats b)
			{
				return 0;
			}

			// Token: 0x040082D7 RID: 33495
			[Token(Token = "0x40082D7")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIHudSingleFightMatchResultController.<>c <>9;

			// Token: 0x040082D8 RID: 33496
			[Token(Token = "0x40082D8")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<TeammateStats> <>9__19_0;
		}
	}
}
