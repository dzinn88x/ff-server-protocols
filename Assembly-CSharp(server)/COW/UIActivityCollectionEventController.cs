using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020013E3 RID: 5091
	[Token(Token = "0x20013E3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC120", Offset = "0x10EC120")]
	public class UIActivityCollectionEventController : UIActivityContentController, IUIModelDataChangeObserver
	{
		// Token: 0x0600538D RID: 21389 RVA: 0x00018F30 File Offset: 0x00017130
		[Token(Token = "0x600538D")]
		[Address(RVA = "0x1A46290", Offset = "0x1A46290", VA = "0x7BBC246290")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600538E RID: 21390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600538E")]
		[Address(RVA = "0x1A462E0", Offset = "0x1A462E0", VA = "0x7BBC2462E0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600538F RID: 21391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600538F")]
		[Address(RVA = "0x1A465F4", Offset = "0x1A465F4", VA = "0x7BBC2465F4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005390 RID: 21392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005390")]
		[Address(RVA = "0x1A46678", Offset = "0x1A46678", VA = "0x7BBC246678", Slot = "28")]
		public override void SetData(object data)
		{
		}

		// Token: 0x06005391 RID: 21393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005391")]
		[Address(RVA = "0x1A4672C", Offset = "0x1A4672C", VA = "0x7BBC24672C")]
		private void UpdateIntroData()
		{
		}

		// Token: 0x06005392 RID: 21394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005392")]
		[Address(RVA = "0x1A46BBC", Offset = "0x1A46BBC", VA = "0x7BBC246BBC")]
		private void UpdateActivityInfo()
		{
		}

		// Token: 0x06005393 RID: 21395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005393")]
		[Address(RVA = "0x1A46E8C", Offset = "0x1A46E8C", VA = "0x7BBC246E8C")]
		private void OnClickToken0()
		{
		}

		// Token: 0x06005394 RID: 21396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005394")]
		[Address(RVA = "0x1A47074", Offset = "0x1A47074", VA = "0x7BBC247074")]
		private void OnClickToken1()
		{
		}

		// Token: 0x06005395 RID: 21397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005395")]
		[Address(RVA = "0x1A4725C", Offset = "0x1A4725C", VA = "0x7BBC24725C")]
		private void OnClickCountDown()
		{
		}

		// Token: 0x06005396 RID: 21398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005396")]
		[Address(RVA = "0x1A473F8", Offset = "0x1A473F8", VA = "0x7BBC2473F8")]
		private void OnClickStore()
		{
		}

		// Token: 0x06005397 RID: 21399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005397")]
		[Address(RVA = "0x1A4740C", Offset = "0x1A4740C", VA = "0x7BBC24740C", Slot = "29")]
		public override void Reload()
		{
		}

		// Token: 0x06005398 RID: 21400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005398")]
		[Address(RVA = "0x1A47534", Offset = "0x1A47534", VA = "0x7BBC247534", Slot = "30")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005399 RID: 21401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005399")]
		[Address(RVA = "0x1A48570", Offset = "0x1A48570", VA = "0x7BBC248570")]
		private void ScrollToFirstNotClaimedItem()
		{
		}

		// Token: 0x0600539A RID: 21402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600539A")]
		[Address(RVA = "0x1A48AFC", Offset = "0x1A48AFC", VA = "0x7BBC248AFC")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113E520", Offset = "0x113E520")]
		private IEnumerator OnEnableRoutine()
		{
			return null;
		}

		// Token: 0x0600539B RID: 21403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600539B")]
		[Address(RVA = "0x1A48B9C", Offset = "0x1A48B9C", VA = "0x7BBC248B9C")]
		private void OnEnable()
		{
		}

		// Token: 0x0600539C RID: 21404 RVA: 0x00018F48 File Offset: 0x00017148
		[Token(Token = "0x600539C")]
		[Address(RVA = "0x1A48BC8", Offset = "0x1A48BC8", VA = "0x7BBC248BC8", Slot = "31")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600539D RID: 21405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600539D")]
		[Address(RVA = "0x1A47B28", Offset = "0x1A47B28", VA = "0x7BBC247B28")]
		private void RefreshList()
		{
		}

		// Token: 0x0600539E RID: 21406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600539E")]
		[Address(RVA = "0x1A49078", Offset = "0x1A49078", VA = "0x7BBC249078")]
		public void SetAD(string url)
		{
		}

		// Token: 0x0600539F RID: 21407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600539F")]
		[Address(RVA = "0x1A4917C", Offset = "0x1A4917C", VA = "0x7BBC24917C")]
		private void OnDownloadFinish()
		{
		}

		// Token: 0x060053A0 RID: 21408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053A0")]
		[Address(RVA = "0x1A47E6C", Offset = "0x1A47E6C", VA = "0x7BBC247E6C")]
		private void UpdateInfos()
		{
		}

		// Token: 0x060053A1 RID: 21409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053A1")]
		[Address(RVA = "0x1A476B8", Offset = "0x1A476B8", VA = "0x7BBC2476B8")]
		private void CreateEventDescList()
		{
		}

		// Token: 0x060053A2 RID: 21410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A2")]
		[Address(RVA = "0x1A492EC", Offset = "0x1A492EC", VA = "0x7BBC2492EC")]
		private UIActivityExchangeItemController CreateEventDesc(ClientActivityDesc desc)
		{
			return null;
		}

		// Token: 0x060053A3 RID: 21411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053A3")]
		[Address(RVA = "0x1A493D8", Offset = "0x1A493D8", VA = "0x7BBC2493D8")]
		public UIActivityCollectionEventController()
		{
		}

		// Token: 0x060053A4 RID: 21412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053A4")]
		[Address(RVA = "0x1A49470", Offset = "0x1A49470", VA = "0x7BBC249470")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E584", Offset = "0x113E584")]
		private void <UpdateInfos>b__26_0()
		{
		}

		// Token: 0x0400793A RID: 31034
		[Token(Token = "0x400793A")]
		[FieldOffset(Offset = "0x58")]
		private List<UIActivityCollectionSigninItemController> m_ItemList;

		// Token: 0x0400793B RID: 31035
		[Token(Token = "0x400793B")]
		[FieldOffset(Offset = "0x60")]
		private UIActivityCollectionEventView m_View;

		// Token: 0x0400793C RID: 31036
		[Token(Token = "0x400793C")]
		[FieldOffset(Offset = "0x68")]
		private ActivityGroupDesc m_GroupDesc;

		// Token: 0x0400793D RID: 31037
		[Token(Token = "0x400793D")]
		[FieldOffset(Offset = "0x70")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x0400793E RID: 31038
		[Token(Token = "0x400793E")]
		[FieldOffset(Offset = "0x78")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x0400793F RID: 31039
		[Token(Token = "0x400793F")]
		[FieldOffset(Offset = "0x80")]
		private List<UIActivityExchangeItemController> m_ExchangeDescUIs;

		// Token: 0x04007940 RID: 31040
		[Token(Token = "0x4007940")]
		[FieldOffset(Offset = "0x88")]
		private int m_ADWidth;

		// Token: 0x020013E4 RID: 5092
		[Token(Token = "0x20013E4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC158", Offset = "0x10EC158")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060053A6 RID: 21414 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60053A6")]
			[Address(RVA = "0x1A49530", Offset = "0x1A49530", VA = "0x7BBC249530")]
			public <>c()
			{
			}

			// Token: 0x060053A7 RID: 21415 RVA: 0x00018F60 File Offset: 0x00017160
			[Token(Token = "0x60053A7")]
			[Address(RVA = "0x1A49538", Offset = "0x1A49538", VA = "0x7BBC249538")]
			internal bool <ScrollToFirstNotClaimedItem>b__19_0(UIActivityCollectionSigninItemController temp)
			{
				return default(bool);
			}

			// Token: 0x04007941 RID: 31041
			[Token(Token = "0x4007941")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIActivityCollectionEventController.<>c <>9;

			// Token: 0x04007942 RID: 31042
			[Token(Token = "0x4007942")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<UIActivityCollectionSigninItemController> <>9__19_0;
		}

		// Token: 0x020013E5 RID: 5093
		[Token(Token = "0x20013E5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC168", Offset = "0x10EC168")]
		private sealed class <OnEnableRoutine>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060053A8 RID: 21416 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60053A8")]
			[Address(RVA = "0x1A48B70", Offset = "0x1A48B70", VA = "0x7BBC248B70")]
			[DebuggerHidden]
			public <OnEnableRoutine>d__20(int <>1__state)
			{
			}

			// Token: 0x060053A9 RID: 21417 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60053A9")]
			[Address(RVA = "0x1A49584", Offset = "0x1A49584", VA = "0x7BBC249584", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060053AA RID: 21418 RVA: 0x00018F78 File Offset: 0x00017178
			[Token(Token = "0x60053AA")]
			[Address(RVA = "0x1A49588", Offset = "0x1A49588", VA = "0x7BBC249588", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000874 RID: 2164
			// (get) Token: 0x060053AB RID: 21419 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000874")]
			private object Current
			{
				[Token(Token = "0x60053AB")]
				[Address(RVA = "0x1A49620", Offset = "0x1A49620", VA = "0x7BBC249620", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060053AC RID: 21420 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60053AC")]
			[Address(RVA = "0x1A49628", Offset = "0x1A49628", VA = "0x7BBC249628", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000875 RID: 2165
			// (get) Token: 0x060053AD RID: 21421 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000875")]
			private object Current
			{
				[Token(Token = "0x60053AD")]
				[Address(RVA = "0x1A49690", Offset = "0x1A49690", VA = "0x7BBC249690", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007943 RID: 31043
			[Token(Token = "0x4007943")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007944 RID: 31044
			[Token(Token = "0x4007944")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007945 RID: 31045
			[Token(Token = "0x4007945")]
			[FieldOffset(Offset = "0x20")]
			public UIActivityCollectionEventController <>4__this;
		}
	}
}
