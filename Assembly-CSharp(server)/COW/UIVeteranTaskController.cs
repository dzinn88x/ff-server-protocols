using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001BD2 RID: 7122
	[Token(Token = "0x2001BD2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FAEDC", Offset = "0x10FAEDC")]
	public class UIVeteranTaskController : UIBaseController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x060099FB RID: 39419 RVA: 0x00028878 File Offset: 0x00026A78
		[Token(Token = "0x60099FB")]
		[Address(RVA = "0x1680794", Offset = "0x1680794", VA = "0x7BBBE80794")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060099FC RID: 39420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099FC")]
		[Address(RVA = "0x16807E4", Offset = "0x16807E4", VA = "0x7BBBE807E4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060099FD RID: 39421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099FD")]
		[Address(RVA = "0x1681210", Offset = "0x1681210", VA = "0x7BBBE81210", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060099FE RID: 39422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099FE")]
		[Address(RVA = "0x1681254", Offset = "0x1681254", VA = "0x7BBBE81254")]
		public void OnClickRewardBtn()
		{
		}

		// Token: 0x060099FF RID: 39423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099FF")]
		[Address(RVA = "0x168167C", Offset = "0x168167C", VA = "0x7BBBE8167C")]
		private void OnClickOperation()
		{
		}

		// Token: 0x06009A00 RID: 39424 RVA: 0x00028890 File Offset: 0x00026A90
		[Token(Token = "0x6009A00")]
		[Address(RVA = "0x16816AC", Offset = "0x16816AC", VA = "0x7BBBE816AC", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009A01 RID: 39425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A01")]
		[Address(RVA = "0x16816F0", Offset = "0x16816F0", VA = "0x7BBBE816F0", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06009A02 RID: 39426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A02")]
		[Address(RVA = "0x1680A0C", Offset = "0x1680A0C", VA = "0x7BBBE80A0C")]
		private void UpdateView()
		{
		}

		// Token: 0x06009A03 RID: 39427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A03")]
		[Address(RVA = "0x16817AC", Offset = "0x16817AC", VA = "0x7BBBE817AC")]
		private void UpdateClaimInfo()
		{
		}

		// Token: 0x06009A04 RID: 39428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009A04")]
		[Address(RVA = "0x1681BE0", Offset = "0x1681BE0", VA = "0x7BBBE81BE0", Slot = "30")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06009A05 RID: 39429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A05")]
		[Address(RVA = "0x1681C74", Offset = "0x1681C74", VA = "0x7BBBE81C74", Slot = "31")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06009A06 RID: 39430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A06")]
		[Address(RVA = "0x1681CA4", Offset = "0x1681CA4", VA = "0x7BBBE81CA4")]
		public UIVeteranTaskController()
		{
		}

		// Token: 0x06009A07 RID: 39431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009A07")]
		[Address(RVA = "0x1681CB8", Offset = "0x1681CB8", VA = "0x7BBBE81CB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144FC8", Offset = "0x1144FC8")]
		private void <UpdateView>b__12_3(Texture texture)
		{
		}

		// Token: 0x0400A105 RID: 41221
		[Token(Token = "0x400A105")]
		[FieldOffset(Offset = "0x58")]
		private uint GREY_COLOR;

		// Token: 0x0400A106 RID: 41222
		[Token(Token = "0x400A106")]
		[FieldOffset(Offset = "0x60")]
		private UIModelVeteranSignin m_VeteranModel;

		// Token: 0x0400A107 RID: 41223
		[Token(Token = "0x400A107")]
		[FieldOffset(Offset = "0x68")]
		private UIVeteranTaskView m_View;

		// Token: 0x0400A108 RID: 41224
		[Token(Token = "0x400A108")]
		private const string PROGRESS_FORMAT = "{0}/{1}";

		// Token: 0x0400A109 RID: 41225
		[Token(Token = "0x400A109")]
		[FieldOffset(Offset = "0x70")]
		private BaseItemInfo m_RewardInfo;

		// Token: 0x02001BD3 RID: 7123
		[Token(Token = "0x2001BD3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FAF14", Offset = "0x10FAF14")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06009A09 RID: 39433 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009A09")]
			[Address(RVA = "0x1681E24", Offset = "0x1681E24", VA = "0x7BBBE81E24")]
			public <>c()
			{
			}

			// Token: 0x06009A0A RID: 39434 RVA: 0x000288A8 File Offset: 0x00026AA8
			[Token(Token = "0x6009A0A")]
			[Address(RVA = "0x1681E2C", Offset = "0x1681E2C", VA = "0x7BBBE81E2C")]
			internal int <UpdateView>b__12_0(ClientVeteranTaskDesc x, ClientVeteranTaskDesc y)
			{
				return 0;
			}

			// Token: 0x06009A0B RID: 39435 RVA: 0x000288C0 File Offset: 0x00026AC0
			[Token(Token = "0x6009A0B")]
			[Address(RVA = "0x1681E70", Offset = "0x1681E70", VA = "0x7BBBE81E70")]
			internal int <UpdateView>b__12_1(ClientVeteranTaskDesc x, ClientVeteranTaskDesc y)
			{
				return 0;
			}

			// Token: 0x06009A0C RID: 39436 RVA: 0x000288D8 File Offset: 0x00026AD8
			[Token(Token = "0x6009A0C")]
			[Address(RVA = "0x1681EB4", Offset = "0x1681EB4", VA = "0x7BBBE81EB4")]
			internal int <UpdateView>b__12_2(ClientVeteranTaskDesc x, ClientVeteranTaskDesc y)
			{
				return 0;
			}

			// Token: 0x0400A10A RID: 41226
			[Token(Token = "0x400A10A")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIVeteranTaskController.<>c <>9;

			// Token: 0x0400A10B RID: 41227
			[Token(Token = "0x400A10B")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<ClientVeteranTaskDesc> <>9__12_0;

			// Token: 0x0400A10C RID: 41228
			[Token(Token = "0x400A10C")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<ClientVeteranTaskDesc> <>9__12_1;

			// Token: 0x0400A10D RID: 41229
			[Token(Token = "0x400A10D")]
			[FieldOffset(Offset = "0x18")]
			public static Comparison<ClientVeteranTaskDesc> <>9__12_2;
		}
	}
}
