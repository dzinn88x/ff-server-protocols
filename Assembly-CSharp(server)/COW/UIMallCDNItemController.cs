using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001584 RID: 5508
	[Token(Token = "0x2001584")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EEBDC", Offset = "0x10EEBDC")]
	public class UIMallCDNItemController : UIMallItemBaseController
	{
		// Token: 0x06006010 RID: 24592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006010")]
		[Address(RVA = "0x1CE84C0", Offset = "0x1CE84C0", VA = "0x7BBC4E84C0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006011 RID: 24593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006011")]
		[Address(RVA = "0x1CE9B5C", Offset = "0x1CE9B5C", VA = "0x7BBC4E9B5C", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x06006012 RID: 24594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006012")]
		[Address(RVA = "0x1CE9E74", Offset = "0x1CE9E74", VA = "0x7BBC4E9E74", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06006013 RID: 24595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006013")]
		[Address(RVA = "0x1CE91F4", Offset = "0x1CE91F4", VA = "0x7BBC4E91F4", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006014 RID: 24596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006014")]
		[Address(RVA = "0x1CE8904", Offset = "0x1CE8904", VA = "0x7BBC4E8904")]
		protected void RefreshDiscountTag(UILabel discountLabel, StoreDesc m_Info)
		{
		}

		// Token: 0x06006015 RID: 24597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006015")]
		[Address(RVA = "0x1CE87B0", Offset = "0x1CE87B0", VA = "0x7BBC4E87B0", Slot = "39")]
		protected override void RefreshItemView()
		{
		}

		// Token: 0x06006016 RID: 24598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006016")]
		[Address(RVA = "0x1CE9080", Offset = "0x1CE9080", VA = "0x7BBC4E9080", Slot = "40")]
		protected override void ResetState()
		{
		}

		// Token: 0x06006017 RID: 24599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006017")]
		[Address(RVA = "0x1CE8A50", Offset = "0x1CE8A50", VA = "0x7BBC4E8A50")]
		protected void SetPriceInfo(UITable priceContainer, GameObject diamondIcon, UILabel diamondPrice, GameObject goldIcon, GameObject slash, UILabel goldPrice, UILabel originalPrice, StoreDesc desc, UIWidget spriteBG)
		{
		}

		// Token: 0x06006018 RID: 24600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006018")]
		[Address(RVA = "0x1CE9EB4", Offset = "0x1CE9EB4", VA = "0x7BBC4E9EB4")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113FC80", Offset = "0x113FC80")]
		private IEnumerator PriceTableReposition(UITable table, UIWidget spriteBG)
		{
			return null;
		}

		// Token: 0x06006019 RID: 24601 RVA: 0x0001BC30 File Offset: 0x00019E30
		[Token(Token = "0x6006019")]
		[Address(RVA = "0x1CE9F60", Offset = "0x1CE9F60", VA = "0x7BBC4E9F60")]
		protected Bounds CalcPriceContainerBounds(Transform priceContainer)
		{
			return default(Bounds);
		}

		// Token: 0x0600601A RID: 24602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600601A")]
		[Address(RVA = "0x1CE9688", Offset = "0x1CE9688", VA = "0x7BBC4E9688")]
		public UIMallCDNItemController()
		{
		}

		// Token: 0x0400804F RID: 32847
		[Token(Token = "0x400804F")]
		[FieldOffset(Offset = "0x220")]
		protected string m_URL;

		// Token: 0x04008050 RID: 32848
		[Token(Token = "0x4008050")]
		[FieldOffset(Offset = "0x228")]
		private int PriceBGExtraWidth;

		// Token: 0x04008051 RID: 32849
		[Token(Token = "0x4008051")]
		[FieldOffset(Offset = "0x22C")]
		private int PriceBGMinWidth;

		// Token: 0x02001585 RID: 5509
		[Token(Token = "0x2001585")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EEC14", Offset = "0x10EEC14")]
		private sealed class <PriceTableReposition>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600601B RID: 24603 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600601B")]
			[Address(RVA = "0x1C579D0", Offset = "0x1C579D0", VA = "0x7BBC4579D0")]
			[DebuggerHidden]
			public <PriceTableReposition>d__11(int <>1__state)
			{
			}

			// Token: 0x0600601C RID: 24604 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600601C")]
			[Address(RVA = "0x1C579FC", Offset = "0x1C579FC", VA = "0x7BBC4579FC", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600601D RID: 24605 RVA: 0x0001BC48 File Offset: 0x00019E48
			[Token(Token = "0x600601D")]
			[Address(RVA = "0x1C57A00", Offset = "0x1C57A00", VA = "0x7BBC457A00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170008B8 RID: 2232
			// (get) Token: 0x0600601E RID: 24606 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008B8")]
			private object Current
			{
				[Token(Token = "0x600601E")]
				[Address(RVA = "0x1C57B48", Offset = "0x1C57B48", VA = "0x7BBC457B48", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600601F RID: 24607 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600601F")]
			[Address(RVA = "0x1C57B50", Offset = "0x1C57B50", VA = "0x7BBC457B50", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170008B9 RID: 2233
			// (get) Token: 0x06006020 RID: 24608 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008B9")]
			private object Current
			{
				[Token(Token = "0x6006020")]
				[Address(RVA = "0x1C57BB8", Offset = "0x1C57BB8", VA = "0x7BBC457BB8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008052 RID: 32850
			[Token(Token = "0x4008052")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008053 RID: 32851
			[Token(Token = "0x4008053")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008054 RID: 32852
			[Token(Token = "0x4008054")]
			[FieldOffset(Offset = "0x20")]
			public UITable table;

			// Token: 0x04008055 RID: 32853
			[Token(Token = "0x4008055")]
			[FieldOffset(Offset = "0x28")]
			public UIMallCDNItemController <>4__this;

			// Token: 0x04008056 RID: 32854
			[Token(Token = "0x4008056")]
			[FieldOffset(Offset = "0x30")]
			public UIWidget spriteBG;
		}
	}
}
