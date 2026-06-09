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
	// Token: 0x02001820 RID: 6176
	[Token(Token = "0x2001820")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3714", Offset = "0x10F3714")]
	public class UIGachaTokenContent : UIGachaContentBase
	{
		// Token: 0x06007885 RID: 30853 RVA: 0x000213A8 File Offset: 0x0001F5A8
		[Token(Token = "0x6007885")]
		[Address(RVA = "0x1FA3A44", Offset = "0x1FA3A44", VA = "0x7BBC7A3A44")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007886 RID: 30854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007886")]
		[Address(RVA = "0x1FA3A94", Offset = "0x1FA3A94", VA = "0x7BBC7A3A94", Slot = "50")]
		public override string GetTutorialWndTitleKey()
		{
			return null;
		}

		// Token: 0x06007887 RID: 30855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007887")]
		[Address(RVA = "0x1FA3ADC", Offset = "0x1FA3ADC", VA = "0x7BBC7A3ADC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007888 RID: 30856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007888")]
		[Address(RVA = "0x1FA41B4", Offset = "0x1FA41B4", VA = "0x7BBC7A41B4", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06007889 RID: 30857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007889")]
		[Address(RVA = "0x1FA41BC", Offset = "0x1FA41BC", VA = "0x7BBC7A41BC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600788A RID: 30858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600788A")]
		[Address(RVA = "0x1FA4534", Offset = "0x1FA4534", VA = "0x7BBC7A4534", Slot = "30")]
		protected override void InitGachaContentBuyBtn()
		{
		}

		// Token: 0x0600788B RID: 30859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600788B")]
		[Address(RVA = "0x1FA45F8", Offset = "0x1FA45F8", VA = "0x7BBC7A45F8", Slot = "48")]
		protected override void OnCloseRewardPanel()
		{
		}

		// Token: 0x0600788C RID: 30860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600788C")]
		[Address(RVA = "0x1FA4FDC", Offset = "0x1FA4FDC", VA = "0x7BBC7A4FDC", Slot = "21")]
		public override void Show()
		{
		}

		// Token: 0x0600788D RID: 30861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600788D")]
		[Address(RVA = "0x1FA4FE4", Offset = "0x1FA4FE4", VA = "0x7BBC7A4FE4", Slot = "31")]
		protected override void OnRefreshUIView()
		{
		}

		// Token: 0x0600788E RID: 30862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600788E")]
		[Address(RVA = "0x1FA5AD8", Offset = "0x1FA5AD8", VA = "0x7BBC7A5AD8", Slot = "34")]
		public override void OnHideContent()
		{
		}

		// Token: 0x0600788F RID: 30863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600788F")]
		[Address(RVA = "0x1FA5BD8", Offset = "0x1FA5BD8", VA = "0x7BBC7A5BD8", Slot = "44")]
		public override void GetPreviewSceneBorder(uint gachaID, out Vector3 left, out Vector3 right)
		{
		}

		// Token: 0x06007890 RID: 30864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007890")]
		[Address(RVA = "0x1FA5E28", Offset = "0x1FA5E28", VA = "0x7BBC7A5E28", Slot = "38")]
		public override void OnSkipAnim()
		{
		}

		// Token: 0x06007891 RID: 30865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007891")]
		[Address(RVA = "0x1FA6120", Offset = "0x1FA6120", VA = "0x7BBC7A6120")]
		private void OnClickLotteryMachineEvt(params object[] data)
		{
		}

		// Token: 0x06007892 RID: 30866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007892")]
		[Address(RVA = "0x1FA6464", Offset = "0x1FA6464", VA = "0x7BBC7A6464", Slot = "37")]
		public override void OnPurchaseResult(bool isSuccess)
		{
		}

		// Token: 0x06007893 RID: 30867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007893")]
		[Address(RVA = "0x1FA65EC", Offset = "0x1FA65EC", VA = "0x7BBC7A65EC", Slot = "41")]
		public override void OnRewardPoolClose()
		{
		}

		// Token: 0x06007894 RID: 30868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007894")]
		[Address(RVA = "0x1FA677C", Offset = "0x1FA677C", VA = "0x7BBC7A677C")]
		public void SetUITokenSprite(UITopButtonGroupController uITopButtonGroupController)
		{
		}

		// Token: 0x06007895 RID: 30869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007895")]
		[Address(RVA = "0x1FA416C", Offset = "0x1FA416C", VA = "0x7BBC7A416C")]
		private void SetextraAwardActive(bool enable)
		{
		}

		// Token: 0x06007896 RID: 30870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007896")]
		[Address(RVA = "0x1FA6784", Offset = "0x1FA6784", VA = "0x7BBC7A6784", Slot = "42")]
		public override void OnRewardPoolOpen()
		{
		}

		// Token: 0x06007897 RID: 30871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007897")]
		[Address(RVA = "0x1FA6158", Offset = "0x1FA6158", VA = "0x7BBC7A6158")]
		public void OnClickLotteryMachine()
		{
		}

		// Token: 0x06007898 RID: 30872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007898")]
		[Address(RVA = "0x1FA6880", Offset = "0x1FA6880", VA = "0x7BBC7A6880")]
		private void ShowExchangeResultWnd(params object[] data)
		{
		}

		// Token: 0x06007899 RID: 30873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007899")]
		[Address(RVA = "0x1FA6C2C", Offset = "0x1FA6C2C", VA = "0x7BBC7A6C2C")]
		private void OnDrawResultShowed(params object[] data)
		{
		}

		// Token: 0x0600789A RID: 30874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600789A")]
		[Address(RVA = "0x1FA6CDC", Offset = "0x1FA6CDC", VA = "0x7BBC7A6CDC")]
		private void CheckLuckyPointReset()
		{
		}

		// Token: 0x0600789B RID: 30875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600789B")]
		[Address(RVA = "0x1FA6EBC", Offset = "0x1FA6EBC", VA = "0x7BBC7A6EBC")]
		private void OnWeaponCgUIShow(params object[] data)
		{
		}

		// Token: 0x0600789C RID: 30876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600789C")]
		[Address(RVA = "0x1FA6ED0", Offset = "0x1FA6ED0", VA = "0x7BBC7A6ED0")]
		private void OnWeaponCgUIHide(params object[] data)
		{
		}

		// Token: 0x0600789D RID: 30877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600789D")]
		[Address(RVA = "0x1FA6ED8", Offset = "0x1FA6ED8", VA = "0x7BBC7A6ED8")]
		private void OnEnergyPointClick()
		{
		}

		// Token: 0x0600789E RID: 30878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600789E")]
		[Address(RVA = "0x1FA4064", Offset = "0x1FA4064", VA = "0x7BBC7A4064")]
		private void InitExtraAwardList()
		{
		}

		// Token: 0x0600789F RID: 30879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600789F")]
		[Address(RVA = "0x1FA58D4", Offset = "0x1FA58D4", VA = "0x7BBC7A58D4")]
		public void RefreshExtraRewardList(uint chestID)
		{
		}

		// Token: 0x060078A0 RID: 30880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078A0")]
		[Address(RVA = "0x1FA4620", Offset = "0x1FA4620", VA = "0x7BBC7A4620")]
		private void RefreshEnergyPoint(bool needAnim = false)
		{
		}

		// Token: 0x060078A1 RID: 30881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078A1")]
		[Address(RVA = "0x1FA71F4", Offset = "0x1FA71F4", VA = "0x7BBC7A71F4")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1141E78", Offset = "0x1141E78")]
		private IEnumerator RefreshenergyPointCount(uint oldPt, uint pt)
		{
			return null;
		}

		// Token: 0x060078A2 RID: 30882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078A2")]
		[Address(RVA = "0x1FA70A4", Offset = "0x1FA70A4", VA = "0x7BBC7A70A4")]
		public void RereshStarState(int level)
		{
		}

		// Token: 0x060078A3 RID: 30883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078A3")]
		[Address(RVA = "0x1FA72CC", Offset = "0x1FA72CC", VA = "0x7BBC7A72CC")]
		private void ShowExtraPreviewWnd(params object[] data)
		{
		}

		// Token: 0x060078A4 RID: 30884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078A4")]
		[Address(RVA = "0x1FA5030", Offset = "0x1FA5030", VA = "0x7BBC7A5030")]
		private void RefreshCountDownLabel()
		{
		}

		// Token: 0x060078A5 RID: 30885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078A5")]
		[Address(RVA = "0x1FA535C", Offset = "0x1FA535C", VA = "0x7BBC7A535C")]
		private void RefreshCDNContentMask()
		{
		}

		// Token: 0x060078A6 RID: 30886 RVA: 0x000213C0 File Offset: 0x0001F5C0
		[Token(Token = "0x60078A6")]
		[Address(RVA = "0x1FA7494", Offset = "0x1FA7494", VA = "0x7BBC7A7494", Slot = "33")]
		public override uint GetCurrentExchangeItemID()
		{
			return 0U;
		}

		// Token: 0x060078A7 RID: 30887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078A7")]
		[Address(RVA = "0x1FA4AB8", Offset = "0x1FA4AB8", VA = "0x7BBC7A4AB8")]
		public void RefreshTokenView()
		{
		}

		// Token: 0x060078A8 RID: 30888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078A8")]
		[Address(RVA = "0x1FA5514", Offset = "0x1FA5514", VA = "0x7BBC7A5514")]
		public void RefreshCDNView()
		{
		}

		// Token: 0x060078A9 RID: 30889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078A9")]
		[Address(RVA = "0x1FA65E8", Offset = "0x1FA65E8", VA = "0x7BBC7A65E8")]
		private void PlayResultAnim(GachaResultInfo info)
		{
		}

		// Token: 0x060078AA RID: 30890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078AA")]
		[Address(RVA = "0x1FA7958", Offset = "0x1FA7958", VA = "0x7BBC7A7958")]
		private void ProcessAnimEvt(params object[] data)
		{
		}

		// Token: 0x060078AB RID: 30891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078AB")]
		[Address(RVA = "0x1FA5F30", Offset = "0x1FA5F30", VA = "0x7BBC7A5F30")]
		public void ShowDrawResult(UIModelGacha.GachaDrawType dType, bool enableAnim = true)
		{
		}

		// Token: 0x060078AC RID: 30892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078AC")]
		[Address(RVA = "0x1FA76A0", Offset = "0x1FA76A0", VA = "0x7BBC7A76A0")]
		private void BeginPlayDrawAnim()
		{
		}

		// Token: 0x060078AD RID: 30893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078AD")]
		[Address(RVA = "0x1FA7E1C", Offset = "0x1FA7E1C", VA = "0x7BBC7A7E1C")]
		private void PlayDropBoxAnim()
		{
		}

		// Token: 0x060078AE RID: 30894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078AE")]
		[Address(RVA = "0x1FA7B8C", Offset = "0x1FA7B8C", VA = "0x7BBC7A7B8C")]
		private void EndPlayDrawAnim()
		{
		}

		// Token: 0x060078AF RID: 30895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078AF")]
		[Address(RVA = "0x1FA7A38", Offset = "0x1FA7A38", VA = "0x7BBC7A7A38")]
		private void TryStopAnimation(string evt)
		{
		}

		// Token: 0x060078B0 RID: 30896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078B0")]
		[Address(RVA = "0x1FA4488", Offset = "0x1FA4488", VA = "0x7BBC7A4488")]
		public void ClearCache()
		{
		}

		// Token: 0x060078B1 RID: 30897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078B1")]
		[Address(RVA = "0x1FA8BA0", Offset = "0x1FA8BA0", VA = "0x7BBC7A8BA0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1141EDC", Offset = "0x1141EDC")]
		private IEnumerator IEDestroyAnimation()
		{
			return null;
		}

		// Token: 0x060078B2 RID: 30898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078B2")]
		[Address(RVA = "0x1FA8C40", Offset = "0x1FA8C40", VA = "0x7BBC7A8C40")]
		public UIGachaTokenContent()
		{
		}

		// Token: 0x060078B3 RID: 30899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078B3")]
		[Address(RVA = "0x1FA8D28", Offset = "0x1FA8D28", VA = "0x7BBC7A8D28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1141F40", Offset = "0x1141F40")]
		private void <RefreshCountDownLabel>b__39_0()
		{
		}

		// Token: 0x04008E4E RID: 36430
		[Token(Token = "0x4008E4E")]
		[FieldOffset(Offset = "0x78")]
		private UIGachaTokenContentView m_View;

		// Token: 0x04008E4F RID: 36431
		[Token(Token = "0x4008E4F")]
		[FieldOffset(Offset = "0x80")]
		private List<UIGachaExtraListItemController> m_ExtraList;

		// Token: 0x04008E50 RID: 36432
		[Token(Token = "0x4008E50")]
		[FieldOffset(Offset = "0x88")]
		private List<UIGachaADItemController> m_AdList;

		// Token: 0x04008E51 RID: 36433
		[Token(Token = "0x4008E51")]
		[FieldOffset(Offset = "0x90")]
		private UITopButtonGroupController m_TopButtonGroupController;

		// Token: 0x04008E52 RID: 36434
		[Token(Token = "0x4008E52")]
		[FieldOffset(Offset = "0x98")]
		private Color unShowColor;

		// Token: 0x04008E53 RID: 36435
		[Token(Token = "0x4008E53")]
		[FieldOffset(Offset = "0xA8")]
		private UISprite[] spriteStars;

		// Token: 0x04008E54 RID: 36436
		[Token(Token = "0x4008E54")]
		[FieldOffset(Offset = "0xB0")]
		private bool isOpenRewardPool;

		// Token: 0x04008E55 RID: 36437
		[Token(Token = "0x4008E55")]
		[FieldOffset(Offset = "0xB8")]
		private GameObject m_DrawAnimation;

		// Token: 0x02001821 RID: 6177
		[Token(Token = "0x2001821")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F374C", Offset = "0x10F374C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060078B5 RID: 30901 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078B5")]
			[Address(RVA = "0x1FA8ED0", Offset = "0x1FA8ED0", VA = "0x7BBC7A8ED0")]
			public <>c()
			{
			}

			// Token: 0x060078B6 RID: 30902 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60078B6")]
			[Address(RVA = "0x1FA8ED8", Offset = "0x1FA8ED8", VA = "0x7BBC7A8ED8")]
			internal CommonRewardItemInfo <ShowExchangeResultWnd>b__27_0(ExchangedAward item)
			{
				return null;
			}

			// Token: 0x060078B7 RID: 30903 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078B7")]
			[Address(RVA = "0x1FA8EE4", Offset = "0x1FA8EE4", VA = "0x7BBC7A8EE4")]
			internal void <ShowExchangeResultWnd>b__27_1()
			{
			}

			// Token: 0x04008E56 RID: 36438
			[Token(Token = "0x4008E56")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIGachaTokenContent.<>c <>9;

			// Token: 0x04008E57 RID: 36439
			[Token(Token = "0x4008E57")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<ExchangedAward, CommonRewardItemInfo> <>9__27_0;

			// Token: 0x04008E58 RID: 36440
			[Token(Token = "0x4008E58")]
			[FieldOffset(Offset = "0x10")]
			public static Action <>9__27_1;
		}

		// Token: 0x02001822 RID: 6178
		[Token(Token = "0x2001822")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F375C", Offset = "0x10F375C")]
		private sealed class <RefreshenergyPointCount>d__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060078B8 RID: 30904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078B8")]
			[Address(RVA = "0x1FA72A0", Offset = "0x1FA72A0", VA = "0x7BBC7A72A0")]
			[DebuggerHidden]
			public <RefreshenergyPointCount>d__36(int <>1__state)
			{
			}

			// Token: 0x060078B9 RID: 30905 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078B9")]
			[Address(RVA = "0x1FA9064", Offset = "0x1FA9064", VA = "0x7BBC7A9064", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060078BA RID: 30906 RVA: 0x000213D8 File Offset: 0x0001F5D8
			[Token(Token = "0x60078BA")]
			[Address(RVA = "0x1FA9068", Offset = "0x1FA9068", VA = "0x7BBC7A9068", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000967 RID: 2407
			// (get) Token: 0x060078BB RID: 30907 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000967")]
			private object Current
			{
				[Token(Token = "0x60078BB")]
				[Address(RVA = "0x1FA92C0", Offset = "0x1FA92C0", VA = "0x7BBC7A92C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060078BC RID: 30908 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078BC")]
			[Address(RVA = "0x1FA92C8", Offset = "0x1FA92C8", VA = "0x7BBC7A92C8", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000968 RID: 2408
			// (get) Token: 0x060078BD RID: 30909 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000968")]
			private object Current
			{
				[Token(Token = "0x60078BD")]
				[Address(RVA = "0x1FA9330", Offset = "0x1FA9330", VA = "0x7BBC7A9330", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008E59 RID: 36441
			[Token(Token = "0x4008E59")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008E5A RID: 36442
			[Token(Token = "0x4008E5A")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008E5B RID: 36443
			[Token(Token = "0x4008E5B")]
			[FieldOffset(Offset = "0x20")]
			public uint pt;

			// Token: 0x04008E5C RID: 36444
			[Token(Token = "0x4008E5C")]
			[FieldOffset(Offset = "0x24")]
			public uint oldPt;

			// Token: 0x04008E5D RID: 36445
			[Token(Token = "0x4008E5D")]
			[FieldOffset(Offset = "0x28")]
			public UIGachaTokenContent <>4__this;

			// Token: 0x04008E5E RID: 36446
			[Token(Token = "0x4008E5E")]
			[FieldOffset(Offset = "0x30")]
			private float <currentTime>5__2;
		}

		// Token: 0x02001823 RID: 6179
		[Token(Token = "0x2001823")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F376C", Offset = "0x10F376C")]
		private sealed class <IEDestroyAnimation>d__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060078BE RID: 30910 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078BE")]
			[Address(RVA = "0x1FA8C14", Offset = "0x1FA8C14", VA = "0x7BBC7A8C14")]
			[DebuggerHidden]
			public <IEDestroyAnimation>d__52(int <>1__state)
			{
			}

			// Token: 0x060078BF RID: 30911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078BF")]
			[Address(RVA = "0x1FA8F80", Offset = "0x1FA8F80", VA = "0x7BBC7A8F80", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060078C0 RID: 30912 RVA: 0x000213F0 File Offset: 0x0001F5F0
			[Token(Token = "0x60078C0")]
			[Address(RVA = "0x1FA8F84", Offset = "0x1FA8F84", VA = "0x7BBC7A8F84", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000969 RID: 2409
			// (get) Token: 0x060078C1 RID: 30913 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000969")]
			private object Current
			{
				[Token(Token = "0x60078C1")]
				[Address(RVA = "0x1FA8FEC", Offset = "0x1FA8FEC", VA = "0x7BBC7A8FEC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060078C2 RID: 30914 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078C2")]
			[Address(RVA = "0x1FA8FF4", Offset = "0x1FA8FF4", VA = "0x7BBC7A8FF4", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700096A RID: 2410
			// (get) Token: 0x060078C3 RID: 30915 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700096A")]
			private object Current
			{
				[Token(Token = "0x60078C3")]
				[Address(RVA = "0x1FA905C", Offset = "0x1FA905C", VA = "0x7BBC7A905C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008E5F RID: 36447
			[Token(Token = "0x4008E5F")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008E60 RID: 36448
			[Token(Token = "0x4008E60")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008E61 RID: 36449
			[Token(Token = "0x4008E61")]
			[FieldOffset(Offset = "0x20")]
			public UIGachaTokenContent <>4__this;
		}
	}
}
