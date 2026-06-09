using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001AB3 RID: 6835
	[Token(Token = "0x2001AB3")]
	public class UIPaymentBundleController : UIPaymentController.PaymentTabContentController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x0600903F RID: 36927 RVA: 0x000266E8 File Offset: 0x000248E8
		[Token(Token = "0x600903F")]
		[Address(RVA = "0x16F1808", Offset = "0x16F1808", VA = "0x7BBBEF1808")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009040 RID: 36928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009040")]
		[Address(RVA = "0x16F1858", Offset = "0x16F1858", VA = "0x7BBBEF1858", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009041 RID: 36929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009041")]
		[Address(RVA = "0x16F2330", Offset = "0x16F2330", VA = "0x7BBBEF2330", Slot = "28")]
		public override void GotoByParams(UIPaymentController.PaymentGotoParams parameters)
		{
		}

		// Token: 0x06009042 RID: 36930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009042")]
		[Address(RVA = "0x16F238C", Offset = "0x16F238C", VA = "0x7BBBEF238C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009043 RID: 36931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009043")]
		[Address(RVA = "0x16F2504", Offset = "0x16F2504", VA = "0x7BBBEF2504", Slot = "21")]
		public override void Show()
		{
		}

		// Token: 0x06009044 RID: 36932 RVA: 0x00026700 File Offset: 0x00024900
		[Token(Token = "0x6009044")]
		[Address(RVA = "0x16F2564", Offset = "0x16F2564", VA = "0x7BBBEF2564", Slot = "31")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009045 RID: 36933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009045")]
		[Address(RVA = "0x16F25EC", Offset = "0x16F25EC", VA = "0x7BBBEF25EC", Slot = "30")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06009046 RID: 36934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009046")]
		[Address(RVA = "0x16F26AC", Offset = "0x16F26AC", VA = "0x7BBBEF26AC")]
		private void OnResetTimerFinished()
		{
		}

		// Token: 0x06009047 RID: 36935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009047")]
		[Address(RVA = "0x16F26E4", Offset = "0x16F26E4", VA = "0x7BBBEF26E4", Slot = "29")]
		public override void RefreshContent()
		{
		}

		// Token: 0x06009048 RID: 36936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009048")]
		[Address(RVA = "0x16F1A04", Offset = "0x16F1A04", VA = "0x7BBBEF1A04")]
		private void SetTitles(EStore.PbwActivityType type = EStore.PbwActivityType.PbwActivityType_NONE)
		{
		}

		// Token: 0x06009049 RID: 36937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009049")]
		[Address(RVA = "0x16F2C38", Offset = "0x16F2C38", VA = "0x7BBBEF2C38")]
		private void OnSpecialStoreClicked(EStore.PbwActivityType type)
		{
		}

		// Token: 0x0600904A RID: 36938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600904A")]
		[Address(RVA = "0x16F326C", Offset = "0x16F326C", VA = "0x7BBBEF326C")]
		private void SetBundles(EStore.PbwActivityType type)
		{
		}

		// Token: 0x0600904B RID: 36939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600904B")]
		[Address(RVA = "0x16F3C70", Offset = "0x16F3C70", VA = "0x7BBBEF3C70", Slot = "32")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x0600904C RID: 36940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600904C")]
		[Address(RVA = "0x16F3D04", Offset = "0x16F3D04", VA = "0x7BBBEF3D04", Slot = "33")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x0600904D RID: 36941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600904D")]
		[Address(RVA = "0x16F3D34", Offset = "0x16F3D34", VA = "0x7BBBEF3D34")]
		public UIPaymentBundleController()
		{
		}

		// Token: 0x04009BFF RID: 39935
		[Token(Token = "0x4009BFF")]
		[FieldOffset(Offset = "0x58")]
		private UIPaymentBundleView m_View;

		// Token: 0x04009C00 RID: 39936
		[Token(Token = "0x4009C00")]
		[FieldOffset(Offset = "0x60")]
		private UIModelPayment m_Payment;

		// Token: 0x04009C01 RID: 39937
		[Token(Token = "0x4009C01")]
		[FieldOffset(Offset = "0x68")]
		private bool m_ForceRefresh;

		// Token: 0x04009C02 RID: 39938
		[Token(Token = "0x4009C02")]
		[FieldOffset(Offset = "0x6C")]
		private EStore.PbwActivityType m_SelectedStoreType;

		// Token: 0x04009C03 RID: 39939
		[Token(Token = "0x4009C03")]
		[FieldOffset(Offset = "0x70")]
		private List<UIPaymentBundleItemController> m_BundleItems;

		// Token: 0x04009C04 RID: 39940
		[Token(Token = "0x4009C04")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<EStore.PbwActivityType, UIPaymentBundleTopItemController> m_Titles;

		// Token: 0x02001AB4 RID: 6836
		[Token(Token = "0x2001AB4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F896C", Offset = "0x10F896C")]
		private sealed class <>c__DisplayClass15_0
		{
			// Token: 0x0600904E RID: 36942 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600904E")]
			[Address(RVA = "0x16F26EC", Offset = "0x16F26EC", VA = "0x7BBBEF26EC")]
			public <>c__DisplayClass15_0()
			{
			}

			// Token: 0x0600904F RID: 36943 RVA: 0x00026718 File Offset: 0x00024918
			[Token(Token = "0x600904F")]
			[Address(RVA = "0x16F3EDC", Offset = "0x16F3EDC", VA = "0x7BBBEF3EDC")]
			internal bool <SetTitles>b__0(PayBundleWindowDesc x)
			{
				return default(bool);
			}

			// Token: 0x04009C05 RID: 39941
			[Token(Token = "0x4009C05")]
			[FieldOffset(Offset = "0x10")]
			public SpecialStoreDesc title;
		}

		// Token: 0x02001AB5 RID: 6837
		[Token(Token = "0x2001AB5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F897C", Offset = "0x10F897C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06009051 RID: 36945 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009051")]
			[Address(RVA = "0x16F3E30", Offset = "0x16F3E30", VA = "0x7BBBEF3E30")]
			public <>c()
			{
			}

			// Token: 0x06009052 RID: 36946 RVA: 0x00026730 File Offset: 0x00024930
			[Token(Token = "0x6009052")]
			[Address(RVA = "0x16F3E38", Offset = "0x16F3E38", VA = "0x7BBBEF3E38")]
			internal int <SetBundles>b__17_0(PayBundleWindowDesc a, PayBundleWindowDesc b)
			{
				return 0;
			}

			// Token: 0x04009C06 RID: 39942
			[Token(Token = "0x4009C06")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIPaymentBundleController.<>c <>9;

			// Token: 0x04009C07 RID: 39943
			[Token(Token = "0x4009C07")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<PayBundleWindowDesc> <>9__17_0;
		}
	}
}
