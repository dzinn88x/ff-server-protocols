using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020015F4 RID: 5620
	[Token(Token = "0x20015F4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF6EC", Offset = "0x10EF6EC")]
	internal class UIHudNormalMatchResultController : UIHudMatchResultBaseController
	{
		// Token: 0x06006423 RID: 25635 RVA: 0x0001CC38 File Offset: 0x0001AE38
		[Token(Token = "0x6006423")]
		[Address(RVA = "0x17B8A00", Offset = "0x17B8A00", VA = "0x7BBBFB8A00")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006424 RID: 25636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006424")]
		[Address(RVA = "0x17B8A50", Offset = "0x17B8A50", VA = "0x7BBBFB8A50")]
		public UIHudNormalMatchResultController()
		{
		}

		// Token: 0x06006425 RID: 25637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006425")]
		[Address(RVA = "0x17B8A7C", Offset = "0x17B8A7C", VA = "0x7BBBFB8A7C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006426 RID: 25638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006426")]
		[Address(RVA = "0x17B8F2C", Offset = "0x17B8F2C", VA = "0x7BBBFB8F2C", Slot = "45")]
		protected override void OnShowAvatarInfoUI()
		{
		}

		// Token: 0x06006427 RID: 25639 RVA: 0x0001CC50 File Offset: 0x0001AE50
		[Token(Token = "0x6006427")]
		[Address(RVA = "0x17B8FF4", Offset = "0x17B8FF4", VA = "0x7BBBFB8FF4", Slot = "48")]
		protected override bool CheckIsWin(MatchStats stats)
		{
			return default(bool);
		}

		// Token: 0x06006428 RID: 25640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006428")]
		[Address(RVA = "0x17B9010", Offset = "0x17B9010", VA = "0x7BBBFB9010", Slot = "43")]
		protected override void OnSetMatchResultInfo(MatchStats stats)
		{
		}

		// Token: 0x06006429 RID: 25641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006429")]
		[Address(RVA = "0x17B9D7C", Offset = "0x17B9D7C", VA = "0x7BBBFB9D7C", Slot = "44")]
		protected override void OnShowMatchResultDetailUI(bool show)
		{
		}

		// Token: 0x0600642A RID: 25642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600642A")]
		[Address(RVA = "0x17B9F3C", Offset = "0x17B9F3C", VA = "0x7BBBFB9F3C", Slot = "42")]
		protected override EMatchResultPlayerInfoType[] GetInfoTypes()
		{
			return null;
		}

		// Token: 0x0600642B RID: 25643 RVA: 0x0001CC68 File Offset: 0x0001AE68
		[Token(Token = "0x600642B")]
		[Address(RVA = "0x17BA030", Offset = "0x17BA030", VA = "0x7BBBFBA030", Slot = "40")]
		protected override int SortPlayerData(PlayerData player1, PlayerData player2)
		{
			return 0;
		}

		// Token: 0x0600642C RID: 25644 RVA: 0x0001CC80 File Offset: 0x0001AE80
		[Token(Token = "0x600642C")]
		[Address(RVA = "0x17BA08C", Offset = "0x17BA08C", VA = "0x7BBBFBA08C", Slot = "41")]
		protected override int SortTeammateData(TeammateStats player1, TeammateStats player2)
		{
			return 0;
		}

		// Token: 0x0600642D RID: 25645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600642D")]
		[Address(RVA = "0x17B99A0", Offset = "0x17B99A0", VA = "0x7BBBFB99A0")]
		private TeammateStats ConstructSelfTeammateData(MatchStats stats)
		{
			return null;
		}

		// Token: 0x0600642E RID: 25646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600642E")]
		[Address(RVA = "0x17B9B48", Offset = "0x17B9B48", VA = "0x7BBBFB9B48")]
		private void UpdatePlayerListInfo(List<TeammateStats> players)
		{
		}

		// Token: 0x0600642F RID: 25647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600642F")]
		[Address(RVA = "0x17BA0E8", Offset = "0x17BA0E8", VA = "0x7BBBFBA0E8")]
		private Transform GetItemTransform(int index)
		{
			return null;
		}

		// Token: 0x040082D0 RID: 33488
		[Token(Token = "0x40082D0")]
		[FieldOffset(Offset = "0x210")]
		private UIHudNormalMatchResultView m_View;
	}
}
