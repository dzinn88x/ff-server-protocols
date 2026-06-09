using System;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x02001536 RID: 5430
	[Token(Token = "0x2001536")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE44C", Offset = "0x10EE44C")]
	internal class UILadderMatchRewardListController : UINavigationController, IEasyList
	{
		// Token: 0x06005DB2 RID: 23986 RVA: 0x0001B330 File Offset: 0x00019530
		[Token(Token = "0x6005DB2")]
		[Address(RVA = "0x1E93120", Offset = "0x1E93120", VA = "0x7BBC693120")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005DB3 RID: 23987 RVA: 0x0001B348 File Offset: 0x00019548
		[Token(Token = "0x6005DB3")]
		[Address(RVA = "0x1E93170", Offset = "0x1E93170", VA = "0x7BBC693170", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06005DB4 RID: 23988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DB4")]
		[Address(RVA = "0x1E93178", Offset = "0x1E93178", VA = "0x7BBC693178", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005DB5 RID: 23989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DB5")]
		[Address(RVA = "0x1E93208", Offset = "0x1E93208", VA = "0x7BBC693208", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06005DB6 RID: 23990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DB6")]
		[Address(RVA = "0x1E932C0", Offset = "0x1E932C0", VA = "0x7BBC6932C0")]
		public void SetViewData(f ladderMatchType)
		{
		}

		// Token: 0x06005DB7 RID: 23991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DB7")]
		[Address(RVA = "0x1E932DC", Offset = "0x1E932DC", VA = "0x7BBC6932DC")]
		private void RefreshBRData()
		{
		}

		// Token: 0x06005DB8 RID: 23992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DB8")]
		[Address(RVA = "0x1E93AE0", Offset = "0x1E93AE0", VA = "0x7BBC693AE0")]
		private void RefreshCSData()
		{
		}

		// Token: 0x06005DB9 RID: 23993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DB9")]
		[Address(RVA = "0x1E94064", Offset = "0x1E94064", VA = "0x7BBC694064", Slot = "39")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005DBA RID: 23994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DBA")]
		[Address(RVA = "0x1E940F8", Offset = "0x1E940F8", VA = "0x7BBC6940F8", Slot = "40")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005DBB RID: 23995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DBB")]
		[Address(RVA = "0x1E94128", Offset = "0x1E94128", VA = "0x7BBC694128")]
		public UILadderMatchRewardListController()
		{
		}

		// Token: 0x04007F66 RID: 32614
		[Token(Token = "0x4007F66")]
		[FieldOffset(Offset = "0xB0")]
		private LadderMatchReviewRewardListView m_View;

		// Token: 0x02001537 RID: 5431
		[Token(Token = "0x2001537")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EE484", Offset = "0x10EE484")]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x06005DBC RID: 23996 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005DBC")]
			[Address(RVA = "0x1E94054", Offset = "0x1E94054", VA = "0x7BBC694054")]
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x06005DBD RID: 23997 RVA: 0x0001B360 File Offset: 0x00019560
			[Token(Token = "0x6005DBD")]
			[Address(RVA = "0x1E94130", Offset = "0x1E94130", VA = "0x7BBC694130")]
			internal bool <RefreshBRData>b__0(LadderLevelData a)
			{
				return default(bool);
			}

			// Token: 0x04007F67 RID: 32615
			[Token(Token = "0x4007F67")]
			[FieldOffset(Offset = "0x10")]
			public UIModelLadderMatch model;
		}

		// Token: 0x02001538 RID: 5432
		[Token(Token = "0x2001538")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EE494", Offset = "0x10EE494")]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06005DBE RID: 23998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005DBE")]
			[Address(RVA = "0x1E9405C", Offset = "0x1E9405C", VA = "0x7BBC69405C")]
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x06005DBF RID: 23999 RVA: 0x0001B378 File Offset: 0x00019578
			[Token(Token = "0x6005DBF")]
			[Address(RVA = "0x1E94184", Offset = "0x1E94184", VA = "0x7BBC694184")]
			internal bool <RefreshCSData>b__0(LadderLevelData a)
			{
				return default(bool);
			}

			// Token: 0x04007F68 RID: 32616
			[Token(Token = "0x4007F68")]
			[FieldOffset(Offset = "0x10")]
			public UIModelCSLadderMatch model;
		}
	}
}
