using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001AC7 RID: 6855
	[Token(Token = "0x2001AC7")]
	public class UIPaymentDiamondEventController : UIPaymentController.PaymentTabContentController, IUIModelDataChangeObserver
	{
		// Token: 0x060090A0 RID: 37024 RVA: 0x00026940 File Offset: 0x00024B40
		[Token(Token = "0x60090A0")]
		[Address(RVA = "0x1F21514", Offset = "0x1F21514", VA = "0x7BBC721514")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060090A1 RID: 37025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090A1")]
		[Address(RVA = "0x1F21564", Offset = "0x1F21564", VA = "0x7BBC721564", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060090A2 RID: 37026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090A2")]
		[Address(RVA = "0x1F21734", Offset = "0x1F21734", VA = "0x7BBC721734", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060090A3 RID: 37027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090A3")]
		[Address(RVA = "0x1F218AC", Offset = "0x1F218AC", VA = "0x7BBC7218AC", Slot = "30")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060090A4 RID: 37028 RVA: 0x00026958 File Offset: 0x00024B58
		[Token(Token = "0x60090A4")]
		[Address(RVA = "0x1F21A9C", Offset = "0x1F21A9C", VA = "0x7BBC721A9C", Slot = "31")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060090A5 RID: 37029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090A5")]
		[Address(RVA = "0x1F21AE0", Offset = "0x1F21AE0", VA = "0x7BBC721AE0", Slot = "29")]
		public override void RefreshContent()
		{
		}

		// Token: 0x060090A6 RID: 37030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090A6")]
		[Address(RVA = "0x1F21D0C", Offset = "0x1F21D0C", VA = "0x7BBC721D0C")]
		private void RefreshDiamondItemList(int diamondCount)
		{
		}

		// Token: 0x060090A7 RID: 37031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090A7")]
		[Address(RVA = "0x1F22F3C", Offset = "0x1F22F3C", VA = "0x7BBC722F3C")]
		private void OnPaymentClick()
		{
		}

		// Token: 0x060090A8 RID: 37032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090A8")]
		[Address(RVA = "0x1F21A20", Offset = "0x1F21A20", VA = "0x7BBC721A20")]
		private void OnPurchased(string productIdentifier)
		{
		}

		// Token: 0x060090A9 RID: 37033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090A9")]
		[Address(RVA = "0x1F229B0", Offset = "0x1F229B0", VA = "0x7BBC7229B0")]
		private void RefreshCountDownTime()
		{
		}

		// Token: 0x060090AA RID: 37034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090AA")]
		[Address(RVA = "0x1F232B4", Offset = "0x1F232B4", VA = "0x7BBC7232B4")]
		public UIPaymentDiamondEventController()
		{
		}

		// Token: 0x060090AB RID: 37035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090AB")]
		[Address(RVA = "0x1F23324", Offset = "0x1F23324", VA = "0x7BBC723324")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144888", Offset = "0x1144888")]
		private void <RefreshCountDownTime>b__14_0()
		{
		}

		// Token: 0x04009C47 RID: 40007
		[Token(Token = "0x4009C47")]
		[FieldOffset(Offset = "0x58")]
		private UIPaymentDiamondEventView m_View;

		// Token: 0x04009C48 RID: 40008
		[Token(Token = "0x4009C48")]
		[FieldOffset(Offset = "0x60")]
		private UIModelPayment m_model;

		// Token: 0x04009C49 RID: 40009
		[Token(Token = "0x4009C49")]
		[FieldOffset(Offset = "0x68")]
		private List<UIPaymentDiamondItemController> m_Items;

		// Token: 0x04009C4A RID: 40010
		[Token(Token = "0x4009C4A")]
		[FieldOffset(Offset = "0x70")]
		private string m_ItemIdentifier;

		// Token: 0x04009C4B RID: 40011
		[Token(Token = "0x4009C4B")]
		[FieldOffset(Offset = "0x78")]
		private bool purchased;

		// Token: 0x02001AC8 RID: 6856
		[Token(Token = "0x2001AC8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F8A74", Offset = "0x10F8A74")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060090AD RID: 37037 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60090AD")]
			[Address(RVA = "0x1F233E4", Offset = "0x1F233E4", VA = "0x7BBC7233E4")]
			public <>c()
			{
			}

			// Token: 0x060090AE RID: 37038 RVA: 0x00026970 File Offset: 0x00024B70
			[Token(Token = "0x60090AE")]
			[Address(RVA = "0x1F233EC", Offset = "0x1F233EC", VA = "0x7BBC7233EC")]
			internal int <RefreshDiamondItemList>b__11_0(DiamondSpendEventDesc a, DiamondSpendEventDesc b)
			{
				return 0;
			}

			// Token: 0x04009C4C RID: 40012
			[Token(Token = "0x4009C4C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIPaymentDiamondEventController.<>c <>9;

			// Token: 0x04009C4D RID: 40013
			[Token(Token = "0x4009C4D")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<DiamondSpendEventDesc> <>9__11_0;
		}
	}
}
