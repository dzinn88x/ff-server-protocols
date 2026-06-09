using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200180E RID: 6158
	[Token(Token = "0x200180E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F353C", Offset = "0x10F353C")]
	public class UIGachaNormalContent : UIGachaContentBase
	{
		// Token: 0x060077C5 RID: 30661 RVA: 0x000211C8 File Offset: 0x0001F3C8
		[Token(Token = "0x60077C5")]
		[Address(RVA = "0x20679F4", Offset = "0x20679F4", VA = "0x7BBC8679F4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060077C6 RID: 30662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077C6")]
		[Address(RVA = "0x2067A44", Offset = "0x2067A44", VA = "0x7BBC867A44", Slot = "50")]
		public override string GetTutorialWndTitleKey()
		{
			return null;
		}

		// Token: 0x060077C7 RID: 30663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077C7")]
		[Address(RVA = "0x2067A8C", Offset = "0x2067A8C", VA = "0x7BBC867A8C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060077C8 RID: 30664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077C8")]
		[Address(RVA = "0x2068164", Offset = "0x2068164", VA = "0x7BBC868164", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060077C9 RID: 30665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077C9")]
		[Address(RVA = "0x206816C", Offset = "0x206816C", VA = "0x7BBC86816C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060077CA RID: 30666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077CA")]
		[Address(RVA = "0x20684E4", Offset = "0x20684E4", VA = "0x7BBC8684E4", Slot = "30")]
		protected override void InitGachaContentBuyBtn()
		{
		}

		// Token: 0x060077CB RID: 30667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077CB")]
		[Address(RVA = "0x20685A8", Offset = "0x20685A8", VA = "0x7BBC8685A8", Slot = "48")]
		protected override void OnCloseRewardPanel()
		{
		}

		// Token: 0x060077CC RID: 30668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077CC")]
		[Address(RVA = "0x2068A8C", Offset = "0x2068A8C", VA = "0x7BBC868A8C", Slot = "21")]
		public override void Show()
		{
		}

		// Token: 0x060077CD RID: 30669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077CD")]
		[Address(RVA = "0x2068A94", Offset = "0x2068A94", VA = "0x7BBC868A94", Slot = "31")]
		protected override void OnRefreshUIView()
		{
		}

		// Token: 0x060077CE RID: 30670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077CE")]
		[Address(RVA = "0x2069580", Offset = "0x2069580", VA = "0x7BBC869580", Slot = "44")]
		public override void GetPreviewSceneBorder(uint gachaID, out Vector3 left, out Vector3 right)
		{
		}

		// Token: 0x060077CF RID: 30671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077CF")]
		[Address(RVA = "0x20697D0", Offset = "0x20697D0", VA = "0x7BBC8697D0", Slot = "38")]
		public override void OnSkipAnim()
		{
		}

		// Token: 0x060077D0 RID: 30672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077D0")]
		[Address(RVA = "0x2069AC8", Offset = "0x2069AC8", VA = "0x7BBC869AC8", Slot = "37")]
		public override void OnPurchaseResult(bool isSuccess)
		{
		}

		// Token: 0x060077D1 RID: 30673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077D1")]
		[Address(RVA = "0x2069C50", Offset = "0x2069C50", VA = "0x7BBC869C50", Slot = "41")]
		public override void OnRewardPoolClose()
		{
		}

		// Token: 0x060077D2 RID: 30674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077D2")]
		[Address(RVA = "0x206811C", Offset = "0x206811C", VA = "0x7BBC86811C")]
		private void SetextraAwardActive(bool enable)
		{
		}

		// Token: 0x060077D3 RID: 30675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077D3")]
		[Address(RVA = "0x2069D80", Offset = "0x2069D80", VA = "0x7BBC869D80", Slot = "42")]
		public override void OnRewardPoolOpen()
		{
		}

		// Token: 0x060077D4 RID: 30676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077D4")]
		[Address(RVA = "0x2069E14", Offset = "0x2069E14", VA = "0x7BBC869E14")]
		private void OnClickLotteryMachineEvt(params object[] data)
		{
		}

		// Token: 0x060077D5 RID: 30677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077D5")]
		[Address(RVA = "0x2069E4C", Offset = "0x2069E4C", VA = "0x7BBC869E4C")]
		public void OnClickLotteryMachine()
		{
		}

		// Token: 0x060077D6 RID: 30678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077D6")]
		[Address(RVA = "0x206A158", Offset = "0x206A158", VA = "0x7BBC86A158")]
		private void ShowExchangeResultWnd(params object[] data)
		{
		}

		// Token: 0x060077D7 RID: 30679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077D7")]
		[Address(RVA = "0x206A504", Offset = "0x206A504", VA = "0x7BBC86A504")]
		private void OnDrawResultShowed(params object[] data)
		{
		}

		// Token: 0x060077D8 RID: 30680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077D8")]
		[Address(RVA = "0x206A5B4", Offset = "0x206A5B4", VA = "0x7BBC86A5B4")]
		private void CheckLuckyPointReset()
		{
		}

		// Token: 0x060077D9 RID: 30681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077D9")]
		[Address(RVA = "0x206A794", Offset = "0x206A794", VA = "0x7BBC86A794")]
		private void OnWeaponCgUIShow(params object[] data)
		{
		}

		// Token: 0x060077DA RID: 30682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077DA")]
		[Address(RVA = "0x206A7A8", Offset = "0x206A7A8", VA = "0x7BBC86A7A8")]
		private void OnWeaponCgUIHide(params object[] data)
		{
		}

		// Token: 0x060077DB RID: 30683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077DB")]
		[Address(RVA = "0x206A7B0", Offset = "0x206A7B0", VA = "0x7BBC86A7B0")]
		private void OnEnergyPointClick()
		{
		}

		// Token: 0x060077DC RID: 30684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077DC")]
		[Address(RVA = "0x2068014", Offset = "0x2068014", VA = "0x7BBC868014")]
		private void InitExtraAwardList()
		{
		}

		// Token: 0x060077DD RID: 30685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077DD")]
		[Address(RVA = "0x206937C", Offset = "0x206937C", VA = "0x7BBC86937C")]
		public void RefreshExtraRewardList(uint chestID)
		{
		}

		// Token: 0x060077DE RID: 30686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077DE")]
		[Address(RVA = "0x20685B0", Offset = "0x20685B0", VA = "0x7BBC8685B0")]
		private void RefreshEnergyPoint(bool needAnim = false)
		{
		}

		// Token: 0x060077DF RID: 30687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077DF")]
		[Address(RVA = "0x206AACC", Offset = "0x206AACC", VA = "0x7BBC86AACC")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1141D00", Offset = "0x1141D00")]
		private IEnumerator RefreshenergyPointCount(uint oldPt, uint pt)
		{
			return null;
		}

		// Token: 0x060077E0 RID: 30688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077E0")]
		[Address(RVA = "0x206A97C", Offset = "0x206A97C", VA = "0x7BBC86A97C")]
		public void RereshStarState(int level)
		{
		}

		// Token: 0x060077E1 RID: 30689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077E1")]
		[Address(RVA = "0x206ABA4", Offset = "0x206ABA4", VA = "0x7BBC86ABA4")]
		private void ShowExtraPreviewWnd(params object[] data)
		{
		}

		// Token: 0x060077E2 RID: 30690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077E2")]
		[Address(RVA = "0x2068AD8", Offset = "0x2068AD8", VA = "0x7BBC868AD8")]
		private void RefreshCountDownLabel()
		{
		}

		// Token: 0x060077E3 RID: 30691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077E3")]
		[Address(RVA = "0x2068E04", Offset = "0x2068E04", VA = "0x7BBC868E04")]
		private void RefreshCDNContentMask()
		{
		}

		// Token: 0x060077E4 RID: 30692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077E4")]
		[Address(RVA = "0x2068FBC", Offset = "0x2068FBC", VA = "0x7BBC868FBC")]
		public void RefreshCDNView()
		{
		}

		// Token: 0x060077E5 RID: 30693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077E5")]
		[Address(RVA = "0x2069C4C", Offset = "0x2069C4C", VA = "0x7BBC869C4C")]
		private void PlayResultAnim(GachaResultInfo info)
		{
		}

		// Token: 0x060077E6 RID: 30694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077E6")]
		[Address(RVA = "0x206B024", Offset = "0x206B024", VA = "0x7BBC86B024")]
		private void ProcessAnimEvt(params object[] data)
		{
		}

		// Token: 0x060077E7 RID: 30695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077E7")]
		[Address(RVA = "0x20698D8", Offset = "0x20698D8", VA = "0x7BBC8698D8")]
		public void ShowDrawResult(UIModelGacha.GachaDrawType dType, bool enableAnim = true)
		{
		}

		// Token: 0x060077E8 RID: 30696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077E8")]
		[Address(RVA = "0x206AD6C", Offset = "0x206AD6C", VA = "0x7BBC86AD6C")]
		private void BeginPlayDrawAnim()
		{
		}

		// Token: 0x060077E9 RID: 30697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077E9")]
		[Address(RVA = "0x206B4E8", Offset = "0x206B4E8", VA = "0x7BBC86B4E8")]
		private void PlayDropBoxAnim()
		{
		}

		// Token: 0x060077EA RID: 30698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077EA")]
		[Address(RVA = "0x206B258", Offset = "0x206B258", VA = "0x7BBC86B258")]
		private void EndPlayDrawAnim()
		{
		}

		// Token: 0x060077EB RID: 30699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077EB")]
		[Address(RVA = "0x206B104", Offset = "0x206B104", VA = "0x7BBC86B104")]
		private void TryStopAnimation(string evt)
		{
		}

		// Token: 0x060077EC RID: 30700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077EC")]
		[Address(RVA = "0x2068438", Offset = "0x2068438", VA = "0x7BBC868438")]
		public void ClearCache()
		{
		}

		// Token: 0x060077ED RID: 30701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077ED")]
		[Address(RVA = "0x206B8D0", Offset = "0x206B8D0", VA = "0x7BBC86B8D0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1141D64", Offset = "0x1141D64")]
		private IEnumerator IEDestroyAnimation()
		{
			return null;
		}

		// Token: 0x060077EE RID: 30702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077EE")]
		[Address(RVA = "0x206B970", Offset = "0x206B970", VA = "0x7BBC86B970")]
		public UIGachaNormalContent()
		{
		}

		// Token: 0x060077EF RID: 30703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077EF")]
		[Address(RVA = "0x206BA58", Offset = "0x206BA58", VA = "0x7BBC86BA58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1141DC8", Offset = "0x1141DC8")]
		private void <RefreshCountDownLabel>b__36_0()
		{
		}

		// Token: 0x04008E07 RID: 36359
		[Token(Token = "0x4008E07")]
		[FieldOffset(Offset = "0x78")]
		private UIGachaNormalContentView m_View;

		// Token: 0x04008E08 RID: 36360
		[Token(Token = "0x4008E08")]
		[FieldOffset(Offset = "0x80")]
		private List<UIGachaExtraListItemController> m_ExtraList;

		// Token: 0x04008E09 RID: 36361
		[Token(Token = "0x4008E09")]
		[FieldOffset(Offset = "0x88")]
		private List<UIGachaADItemController> m_AdList;

		// Token: 0x04008E0A RID: 36362
		[Token(Token = "0x4008E0A")]
		[FieldOffset(Offset = "0x90")]
		private Color unShowColor;

		// Token: 0x04008E0B RID: 36363
		[Token(Token = "0x4008E0B")]
		[FieldOffset(Offset = "0xA0")]
		private UISprite[] spriteStars;

		// Token: 0x04008E0C RID: 36364
		[Token(Token = "0x4008E0C")]
		[FieldOffset(Offset = "0xA8")]
		private bool isOpenRewardPool;

		// Token: 0x04008E0D RID: 36365
		[Token(Token = "0x4008E0D")]
		[FieldOffset(Offset = "0xB0")]
		private GameObject m_DrawAnimation;

		// Token: 0x0200180F RID: 6159
		[Token(Token = "0x200180F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F3574", Offset = "0x10F3574")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060077F1 RID: 30705 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077F1")]
			[Address(RVA = "0x206BC00", Offset = "0x206BC00", VA = "0x7BBC86BC00")]
			public <>c()
			{
			}

			// Token: 0x060077F2 RID: 30706 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077F2")]
			[Address(RVA = "0x206BC08", Offset = "0x206BC08", VA = "0x7BBC86BC08")]
			internal CommonRewardItemInfo <ShowExchangeResultWnd>b__24_0(ExchangedAward item)
			{
				return null;
			}

			// Token: 0x060077F3 RID: 30707 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077F3")]
			[Address(RVA = "0x206BC14", Offset = "0x206BC14", VA = "0x7BBC86BC14")]
			internal void <ShowExchangeResultWnd>b__24_1()
			{
			}

			// Token: 0x04008E0E RID: 36366
			[Token(Token = "0x4008E0E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIGachaNormalContent.<>c <>9;

			// Token: 0x04008E0F RID: 36367
			[Token(Token = "0x4008E0F")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<ExchangedAward, CommonRewardItemInfo> <>9__24_0;

			// Token: 0x04008E10 RID: 36368
			[Token(Token = "0x4008E10")]
			[FieldOffset(Offset = "0x10")]
			public static Action <>9__24_1;
		}

		// Token: 0x02001810 RID: 6160
		[Token(Token = "0x2001810")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F3584", Offset = "0x10F3584")]
		private sealed class <RefreshenergyPointCount>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060077F4 RID: 30708 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077F4")]
			[Address(RVA = "0x206AB78", Offset = "0x206AB78", VA = "0x7BBC86AB78")]
			[DebuggerHidden]
			public <RefreshenergyPointCount>d__33(int <>1__state)
			{
			}

			// Token: 0x060077F5 RID: 30709 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077F5")]
			[Address(RVA = "0x206BD94", Offset = "0x206BD94", VA = "0x7BBC86BD94", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060077F6 RID: 30710 RVA: 0x000211E0 File Offset: 0x0001F3E0
			[Token(Token = "0x60077F6")]
			[Address(RVA = "0x206BD98", Offset = "0x206BD98", VA = "0x7BBC86BD98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000960 RID: 2400
			// (get) Token: 0x060077F7 RID: 30711 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000960")]
			private object Current
			{
				[Token(Token = "0x60077F7")]
				[Address(RVA = "0x206BFF0", Offset = "0x206BFF0", VA = "0x7BBC86BFF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060077F8 RID: 30712 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077F8")]
			[Address(RVA = "0x206BFF8", Offset = "0x206BFF8", VA = "0x7BBC86BFF8", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000961 RID: 2401
			// (get) Token: 0x060077F9 RID: 30713 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000961")]
			private object Current
			{
				[Token(Token = "0x60077F9")]
				[Address(RVA = "0x206C060", Offset = "0x206C060", VA = "0x7BBC86C060", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008E11 RID: 36369
			[Token(Token = "0x4008E11")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008E12 RID: 36370
			[Token(Token = "0x4008E12")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008E13 RID: 36371
			[Token(Token = "0x4008E13")]
			[FieldOffset(Offset = "0x20")]
			public uint pt;

			// Token: 0x04008E14 RID: 36372
			[Token(Token = "0x4008E14")]
			[FieldOffset(Offset = "0x24")]
			public uint oldPt;

			// Token: 0x04008E15 RID: 36373
			[Token(Token = "0x4008E15")]
			[FieldOffset(Offset = "0x28")]
			public UIGachaNormalContent <>4__this;

			// Token: 0x04008E16 RID: 36374
			[Token(Token = "0x4008E16")]
			[FieldOffset(Offset = "0x30")]
			private float <currentTime>5__2;
		}

		// Token: 0x02001811 RID: 6161
		[Token(Token = "0x2001811")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F3594", Offset = "0x10F3594")]
		private sealed class <IEDestroyAnimation>d__47 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060077FA RID: 30714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077FA")]
			[Address(RVA = "0x206B944", Offset = "0x206B944", VA = "0x7BBC86B944")]
			[DebuggerHidden]
			public <IEDestroyAnimation>d__47(int <>1__state)
			{
			}

			// Token: 0x060077FB RID: 30715 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077FB")]
			[Address(RVA = "0x206BCB0", Offset = "0x206BCB0", VA = "0x7BBC86BCB0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060077FC RID: 30716 RVA: 0x000211F8 File Offset: 0x0001F3F8
			[Token(Token = "0x60077FC")]
			[Address(RVA = "0x206BCB4", Offset = "0x206BCB4", VA = "0x7BBC86BCB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000962 RID: 2402
			// (get) Token: 0x060077FD RID: 30717 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000962")]
			private object Current
			{
				[Token(Token = "0x60077FD")]
				[Address(RVA = "0x206BD1C", Offset = "0x206BD1C", VA = "0x7BBC86BD1C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060077FE RID: 30718 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077FE")]
			[Address(RVA = "0x206BD24", Offset = "0x206BD24", VA = "0x7BBC86BD24", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000963 RID: 2403
			// (get) Token: 0x060077FF RID: 30719 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000963")]
			private object Current
			{
				[Token(Token = "0x60077FF")]
				[Address(RVA = "0x206BD8C", Offset = "0x206BD8C", VA = "0x7BBC86BD8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008E17 RID: 36375
			[Token(Token = "0x4008E17")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008E18 RID: 36376
			[Token(Token = "0x4008E18")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008E19 RID: 36377
			[Token(Token = "0x4008E19")]
			[FieldOffset(Offset = "0x20")]
			public UIGachaNormalContent <>4__this;
		}
	}
}
