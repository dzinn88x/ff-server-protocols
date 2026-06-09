using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018DD RID: 6365
	[Token(Token = "0x20018DD")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F508C", Offset = "0x10F508C")]
	internal class UIHudHyakkiTeammatesInfoController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06007EF6 RID: 32502 RVA: 0x00022B18 File Offset: 0x00020D18
		[Token(Token = "0x6007EF6")]
		[Address(RVA = "0x19816C8", Offset = "0x19816C8", VA = "0x7BBC1816C8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007EF7 RID: 32503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EF7")]
		[Address(RVA = "0x1981718", Offset = "0x1981718", VA = "0x7BBC181718", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007EF8 RID: 32504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EF8")]
		[Address(RVA = "0x1981BA8", Offset = "0x1981BA8", VA = "0x7BBC181BA8", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06007EF9 RID: 32505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EF9")]
		[Address(RVA = "0x1982010", Offset = "0x1982010", VA = "0x7BBC182010", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007EFA RID: 32506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EFA")]
		[Address(RVA = "0x1982498", Offset = "0x1982498", VA = "0x7BBC182498", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007EFB RID: 32507 RVA: 0x00022B30 File Offset: 0x00020D30
		[Token(Token = "0x6007EFB")]
		[Address(RVA = "0x1982848", Offset = "0x1982848", VA = "0x7BBC182848", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007EFC RID: 32508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EFC")]
		[Address(RVA = "0x198288C", Offset = "0x198288C", VA = "0x7BBC18288C")]
		private void OnPlayerHPChanged(params object[] data)
		{
		}

		// Token: 0x06007EFD RID: 32509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EFD")]
		[Address(RVA = "0x1982C5C", Offset = "0x1982C5C", VA = "0x7BBC182C5C")]
		private void OnRemoveMapMark(object[] data)
		{
		}

		// Token: 0x06007EFE RID: 32510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EFE")]
		[Address(RVA = "0x1982D60", Offset = "0x1982D60", VA = "0x7BBC182D60")]
		private void OnUpdateMapMark(object[] data)
		{
		}

		// Token: 0x06007EFF RID: 32511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007EFF")]
		[Address(RVA = "0x1982E64", Offset = "0x1982E64", VA = "0x7BBC182E64")]
		private void OnPlayerGetOnVehicle(object[] data)
		{
		}

		// Token: 0x06007F00 RID: 32512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F00")]
		[Address(RVA = "0x1982FDC", Offset = "0x1982FDC", VA = "0x7BBC182FDC")]
		private void OnPlayerGetOffVehicle(object[] data)
		{
		}

		// Token: 0x06007F01 RID: 32513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F01")]
		[Address(RVA = "0x1983154", Offset = "0x1983154", VA = "0x7BBC183154")]
		private void OnTeammateQuit(object[] data)
		{
		}

		// Token: 0x06007F02 RID: 32514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F02")]
		[Address(RVA = "0x1983418", Offset = "0x1983418", VA = "0x7BBC183418")]
		private void OnTeamateVadStateChange(object[] data)
		{
		}

		// Token: 0x06007F03 RID: 32515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F03")]
		[Address(RVA = "0x198359C", Offset = "0x198359C", VA = "0x7BBC18359C")]
		private void OnTeamateStateChange(object[] data)
		{
		}

		// Token: 0x06007F04 RID: 32516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F04")]
		[Address(RVA = "0x1983734", Offset = "0x1983734", VA = "0x7BBC183734")]
		private void OnTeamInfoGet(object[] data)
		{
		}

		// Token: 0x06007F05 RID: 32517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F05")]
		[Address(RVA = "0x1983C50", Offset = "0x1983C50", VA = "0x7BBC183C50")]
		private void OnPlayerReviveWalletChange(object[] data)
		{
		}

		// Token: 0x06007F06 RID: 32518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F06")]
		[Address(RVA = "0x1983C54", Offset = "0x1983C54", VA = "0x7BBC183C54")]
		private void OnPlayerRevive(object[] data)
		{
		}

		// Token: 0x06007F07 RID: 32519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F07")]
		[Address(RVA = "0x1982AC8", Offset = "0x1982AC8", VA = "0x7BBC182AC8")]
		private void UpdateBuybackBtns()
		{
		}

		// Token: 0x06007F08 RID: 32520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F08")]
		[Address(RVA = "0x1983E5C", Offset = "0x1983E5C", VA = "0x7BBC183E5C")]
		private void OnUpdateDamage(object[] data)
		{
		}

		// Token: 0x06007F09 RID: 32521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F09")]
		[Address(RVA = "0x1983FC0", Offset = "0x1983FC0", VA = "0x7BBC183FC0")]
		private void OnTeamClick()
		{
		}

		// Token: 0x06007F0A RID: 32522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F0A")]
		[Address(RVA = "0x19840F4", Offset = "0x19840F4", VA = "0x7BBC1840F4")]
		private void OnDamageClick()
		{
		}

		// Token: 0x06007F0B RID: 32523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F0B")]
		[Address(RVA = "0x198422C", Offset = "0x198422C", VA = "0x7BBC18422C")]
		public UIHudHyakkiTeammatesInfoController()
		{
		}

		// Token: 0x04009214 RID: 37396
		[Token(Token = "0x4009214")]
		[FieldOffset(Offset = "0x58")]
		private UIHudHyakkiTeammatesInfoView m_View;

		// Token: 0x04009215 RID: 37397
		[Token(Token = "0x4009215")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<{QAb\u0082~u, UIHudHyakkiTeammateItem> m_Teammates;

		// Token: 0x04009216 RID: 37398
		[Token(Token = "0x4009216")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<ulong, UIHudHyakkiTeammateItem> m_TeammatesWithAccountID;

		// Token: 0x04009217 RID: 37399
		[Token(Token = "0x4009217")]
		[FieldOffset(Offset = "0x70")]
		private UIModelMatch m_MatchModel;

		// Token: 0x04009218 RID: 37400
		[Token(Token = "0x4009218")]
		[FieldOffset(Offset = "0x78")]
		private List<UIHudHyakkiTeammateItem> m_ListTeammateItem;

		// Token: 0x04009219 RID: 37401
		[Token(Token = "0x4009219")]
		[FieldOffset(Offset = "0x80")]
		private bool m_EnoughMoneyToBuyback;

		// Token: 0x0400921A RID: 37402
		[Token(Token = "0x400921A")]
		[FieldOffset(Offset = "0x81")]
		private bool m_LocalPlayerDead;

		// Token: 0x0400921B RID: 37403
		[Token(Token = "0x400921B")]
		[FieldOffset(Offset = "0x84")]
		private int m_PVEReviveGemCost;

		// Token: 0x0400921C RID: 37404
		[Token(Token = "0x400921C")]
		[FieldOffset(Offset = "0x88")]
		private bool isCurShowDamageInfo;

		// Token: 0x020018DE RID: 6366
		[Token(Token = "0x20018DE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F50C4", Offset = "0x10F50C4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06007F0D RID: 32525 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F0D")]
			[Address(RVA = "0x1984308", Offset = "0x1984308", VA = "0x7BBC184308")]
			public <>c()
			{
			}

			// Token: 0x06007F0E RID: 32526 RVA: 0x00022B48 File Offset: 0x00020D48
			[Token(Token = "0x6007F0E")]
			[Address(RVA = "0x1984310", Offset = "0x1984310", VA = "0x7BBC184310")]
			internal int <OnUIInit>b__10_0(Transform transform1, Transform transform2)
			{
				return 0;
			}

			// Token: 0x0400921D RID: 37405
			[Token(Token = "0x400921D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIHudHyakkiTeammatesInfoController.<>c <>9;

			// Token: 0x0400921E RID: 37406
			[Token(Token = "0x400921E")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<Transform> <>9__10_0;
		}
	}
}
