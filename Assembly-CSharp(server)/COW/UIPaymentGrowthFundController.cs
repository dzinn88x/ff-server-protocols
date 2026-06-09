using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001ACC RID: 6860
	[Token(Token = "0x2001ACC")]
	public class UIPaymentGrowthFundController : UIPaymentController.PaymentTabContentController, IUIModelDataChangeObserver
	{
		// Token: 0x060090C5 RID: 37061 RVA: 0x000269D0 File Offset: 0x00024BD0
		[Token(Token = "0x60090C5")]
		[Address(RVA = "0x1F25184", Offset = "0x1F25184", VA = "0x7BBC725184")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060090C6 RID: 37062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090C6")]
		[Address(RVA = "0x1F251D4", Offset = "0x1F251D4", VA = "0x7BBC7251D4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060090C7 RID: 37063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090C7")]
		[Address(RVA = "0x1F25488", Offset = "0x1F25488", VA = "0x7BBC725488", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060090C8 RID: 37064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090C8")]
		[Address(RVA = "0x1F25600", Offset = "0x1F25600", VA = "0x7BBC725600", Slot = "21")]
		public override void Show()
		{
		}

		// Token: 0x060090C9 RID: 37065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090C9")]
		[Address(RVA = "0x1F25660", Offset = "0x1F25660", VA = "0x7BBC725660", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x060090CA RID: 37066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090CA")]
		[Address(RVA = "0x1F256CC", Offset = "0x1F256CC", VA = "0x7BBC7256CC")]
		private void OnClickHint()
		{
		}

		// Token: 0x060090CB RID: 37067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090CB")]
		[Address(RVA = "0x1F25854", Offset = "0x1F25854", VA = "0x7BBC725854")]
		private void OnClickPurchase()
		{
		}

		// Token: 0x060090CC RID: 37068 RVA: 0x000269E8 File Offset: 0x00024BE8
		[Token(Token = "0x60090CC")]
		[Address(RVA = "0x1F258BC", Offset = "0x1F258BC", VA = "0x7BBC7258BC", Slot = "31")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060090CD RID: 37069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090CD")]
		[Address(RVA = "0x1F25944", Offset = "0x1F25944", VA = "0x7BBC725944", Slot = "30")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060090CE RID: 37070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090CE")]
		[Address(RVA = "0x1F25AAC", Offset = "0x1F25AAC", VA = "0x7BBC725AAC", Slot = "29")]
		public override void RefreshContent()
		{
		}

		// Token: 0x060090CF RID: 37071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090CF")]
		[Address(RVA = "0x1F25A34", Offset = "0x1F25A34", VA = "0x7BBC725A34")]
		private void ShowEffect()
		{
		}

		// Token: 0x060090D0 RID: 37072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090D0")]
		[Address(RVA = "0x1F271DC", Offset = "0x1F271DC", VA = "0x7BBC7271DC")]
		private void ScrollToFirstNotClaimedItem()
		{
		}

		// Token: 0x060090D1 RID: 37073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60090D1")]
		[Address(RVA = "0x1F277DC", Offset = "0x1F277DC", VA = "0x7BBC7277DC")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1144898", Offset = "0x1144898")]
		private IEnumerator OnEnableRoutine()
		{
			return null;
		}

		// Token: 0x060090D2 RID: 37074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090D2")]
		[Address(RVA = "0x1F2787C", Offset = "0x1F2787C", VA = "0x7BBC72787C")]
		private void OnEnable()
		{
		}

		// Token: 0x060090D3 RID: 37075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090D3")]
		[Address(RVA = "0x1F278A8", Offset = "0x1F278A8", VA = "0x7BBC7278A8")]
		public UIPaymentGrowthFundController()
		{
		}

		// Token: 0x04009C54 RID: 40020
		[Token(Token = "0x4009C54")]
		[FieldOffset(Offset = "0x58")]
		private UIPaymentGrowthFundView m_View;

		// Token: 0x04009C55 RID: 40021
		[Token(Token = "0x4009C55")]
		[FieldOffset(Offset = "0x60")]
		private UIModelPayment m_Payment;

		// Token: 0x04009C56 RID: 40022
		[Token(Token = "0x4009C56")]
		[FieldOffset(Offset = "0x68")]
		private readonly Dictionary<bool, Color> BUTTON_LABEL_COLOR;

		// Token: 0x04009C57 RID: 40023
		[Token(Token = "0x4009C57")]
		[FieldOffset(Offset = "0x70")]
		private List<UIPaymentGrowthFundItemController> m_Items;

		// Token: 0x04009C58 RID: 40024
		[Token(Token = "0x4009C58")]
		[FieldOffset(Offset = "0x78")]
		private bool m_LastPurchaseState;

		// Token: 0x02001ACD RID: 6861
		[Token(Token = "0x2001ACD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F8AF4", Offset = "0x10F8AF4")]
		private sealed class <OnEnableRoutine>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060090D4 RID: 37076 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60090D4")]
			[Address(RVA = "0x1F27850", Offset = "0x1F27850", VA = "0x7BBC727850")]
			[DebuggerHidden]
			public <OnEnableRoutine>d__17(int <>1__state)
			{
			}

			// Token: 0x060090D5 RID: 37077 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60090D5")]
			[Address(RVA = "0x1F279EC", Offset = "0x1F279EC", VA = "0x7BBC7279EC", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060090D6 RID: 37078 RVA: 0x00026A00 File Offset: 0x00024C00
			[Token(Token = "0x60090D6")]
			[Address(RVA = "0x1F279F0", Offset = "0x1F279F0", VA = "0x7BBC7279F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009F8 RID: 2552
			// (get) Token: 0x060090D7 RID: 37079 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009F8")]
			private object Current
			{
				[Token(Token = "0x60090D7")]
				[Address(RVA = "0x1F27A88", Offset = "0x1F27A88", VA = "0x7BBC727A88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060090D8 RID: 37080 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60090D8")]
			[Address(RVA = "0x1F27A90", Offset = "0x1F27A90", VA = "0x7BBC727A90", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009F9 RID: 2553
			// (get) Token: 0x060090D9 RID: 37081 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009F9")]
			private object Current
			{
				[Token(Token = "0x60090D9")]
				[Address(RVA = "0x1F27AF8", Offset = "0x1F27AF8", VA = "0x7BBC727AF8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04009C59 RID: 40025
			[Token(Token = "0x4009C59")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04009C5A RID: 40026
			[Token(Token = "0x4009C5A")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04009C5B RID: 40027
			[Token(Token = "0x4009C5B")]
			[FieldOffset(Offset = "0x20")]
			public UIPaymentGrowthFundController <>4__this;
		}
	}
}
