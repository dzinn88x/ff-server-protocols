using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020017EC RID: 6124
	[Token(Token = "0x20017EC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F315C", Offset = "0x10F315C")]
	public class UIGachalegendaryContent : UIGachaContentBase, IUIModelDataChangeObserver
	{
		// Token: 0x06007689 RID: 30345 RVA: 0x00020DC0 File Offset: 0x0001EFC0
		[Token(Token = "0x6007689")]
		[Address(RVA = "0x1FB0330", Offset = "0x1FB0330", VA = "0x7BBC7B0330")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600768A RID: 30346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600768A")]
		[Address(RVA = "0x1FB0380", Offset = "0x1FB0380", VA = "0x7BBC7B0380", Slot = "50")]
		public override string GetTutorialWndTitleKey()
		{
			return null;
		}

		// Token: 0x0600768B RID: 30347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600768B")]
		[Address(RVA = "0x1FB03C8", Offset = "0x1FB03C8", VA = "0x7BBC7B03C8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600768C RID: 30348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600768C")]
		[Address(RVA = "0x1FB0800", Offset = "0x1FB0800", VA = "0x7BBC7B0800")]
		private void InitItemLevelBtn()
		{
		}

		// Token: 0x0600768D RID: 30349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600768D")]
		[Address(RVA = "0x1FB0D54", Offset = "0x1FB0D54", VA = "0x7BBC7B0D54", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600768E RID: 30350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600768E")]
		[Address(RVA = "0x1FB0F34", Offset = "0x1FB0F34", VA = "0x7BBC7B0F34", Slot = "30")]
		protected override void InitGachaContentBuyBtn()
		{
		}

		// Token: 0x0600768F RID: 30351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600768F")]
		[Address(RVA = "0x1FB0F38", Offset = "0x1FB0F38", VA = "0x7BBC7B0F38")]
		private void ProcessAnimEvt(params object[] data)
		{
		}

		// Token: 0x06007690 RID: 30352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007690")]
		[Address(RVA = "0x1FB1040", Offset = "0x1FB1040", VA = "0x7BBC7B1040")]
		private void OnLegendaryCgOver(params object[] data)
		{
		}

		// Token: 0x06007691 RID: 30353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007691")]
		[Address(RVA = "0x1FB1198", Offset = "0x1FB1198", VA = "0x7BBC7B1198", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06007692 RID: 30354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007692")]
		[Address(RVA = "0x1FB11A0", Offset = "0x1FB11A0", VA = "0x7BBC7B11A0")]
		public void RefreshView(uint chestID)
		{
		}

		// Token: 0x06007693 RID: 30355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007693")]
		[Address(RVA = "0x1FB131C", Offset = "0x1FB131C", VA = "0x7BBC7B131C")]
		private void RefreshBuyBuffButton()
		{
		}

		// Token: 0x06007694 RID: 30356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007694")]
		[Address(RVA = "0x1FB1738", Offset = "0x1FB1738", VA = "0x7BBC7B1738")]
		private void ShowBuffLabelEffect()
		{
		}

		// Token: 0x06007695 RID: 30357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007695")]
		[Address(RVA = "0x1FB1770", Offset = "0x1FB1770", VA = "0x7BBC7B1770")]
		public void PlayLengendaryAnim(string anim)
		{
		}

		// Token: 0x06007696 RID: 30358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007696")]
		[Address(RVA = "0x1FB17B8", Offset = "0x1FB17B8", VA = "0x7BBC7B17B8")]
		private void RefreshEnergyProgress()
		{
		}

		// Token: 0x06007697 RID: 30359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007697")]
		[Address(RVA = "0x1FB1A14", Offset = "0x1FB1A14", VA = "0x7BBC7B1A14")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11419F0", Offset = "0x11419F0")]
		private IEnumerator PlayEnergyProgressAnim(uint startPoint, uint endPoint)
		{
			return null;
		}

		// Token: 0x06007698 RID: 30360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007698")]
		[Address(RVA = "0x1FB08F4", Offset = "0x1FB08F4", VA = "0x7BBC7B08F4")]
		private void SetProgressBarValue(float value)
		{
		}

		// Token: 0x06007699 RID: 30361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007699")]
		[Address(RVA = "0x1FB1AF0", Offset = "0x1FB1AF0", VA = "0x7BBC7B1AF0")]
		public void OnClickRewardPoolBtn()
		{
		}

		// Token: 0x0600769A RID: 30362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600769A")]
		[Address(RVA = "0x1FB1E5C", Offset = "0x1FB1E5C", VA = "0x7BBC7B1E5C")]
		private void OnChangeItemLevelShowClick_3()
		{
		}

		// Token: 0x0600769B RID: 30363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600769B")]
		[Address(RVA = "0x1FB1E80", Offset = "0x1FB1E80", VA = "0x7BBC7B1E80")]
		private void ChangeItemLevelShow()
		{
		}

		// Token: 0x0600769C RID: 30364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600769C")]
		[Address(RVA = "0x1FB1E78", Offset = "0x1FB1E78", VA = "0x7BBC7B1E78")]
		private void ChangeItemLevelShowSkipAnim()
		{
		}

		// Token: 0x0600769D RID: 30365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600769D")]
		[Address(RVA = "0x1FB1F6C", Offset = "0x1FB1F6C", VA = "0x7BBC7B1F6C")]
		private void OnChangeLevelItemShow(uint level)
		{
		}

		// Token: 0x0600769E RID: 30366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600769E")]
		[Address(RVA = "0x1FB1F70", Offset = "0x1FB1F70", VA = "0x7BBC7B1F70", Slot = "32")]
		public override void OnReplayFullScreenAnim()
		{
		}

		// Token: 0x0600769F RID: 30367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600769F")]
		[Address(RVA = "0x1FB1E88", Offset = "0x1FB1E88", VA = "0x7BBC7B1E88")]
		private void ChangeStateBtnShow(uint level)
		{
		}

		// Token: 0x060076A0 RID: 30368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076A0")]
		[Address(RVA = "0x1FB1F80", Offset = "0x1FB1F80", VA = "0x7BBC7B1F80")]
		private void OnLuckProgressClick()
		{
		}

		// Token: 0x060076A1 RID: 30369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076A1")]
		[Address(RVA = "0x1FB2314", Offset = "0x1FB2314", VA = "0x7BBC7B2314")]
		private void OnClickBuffTipsBtn()
		{
		}

		// Token: 0x060076A2 RID: 30370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076A2")]
		[Address(RVA = "0x1FB11FC", Offset = "0x1FB11FC", VA = "0x7BBC7B11FC")]
		private void RefreshCountDownLabel()
		{
		}

		// Token: 0x060076A3 RID: 30371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076A3")]
		[Address(RVA = "0x1FB0B48", Offset = "0x1FB0B48", VA = "0x7BBC7B0B48")]
		public void ShowItemDescInfo(bool showDesc)
		{
		}

		// Token: 0x060076A4 RID: 30372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076A4")]
		[Address(RVA = "0x1FB26A8", Offset = "0x1FB26A8", VA = "0x7BBC7B26A8", Slot = "41")]
		public override void OnRewardPoolClose()
		{
		}

		// Token: 0x060076A5 RID: 30373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076A5")]
		[Address(RVA = "0x1FB2824", Offset = "0x1FB2824", VA = "0x7BBC7B2824", Slot = "44")]
		public override void GetPreviewSceneBorder(uint gachaID, out Vector3 left, out Vector3 right)
		{
		}

		// Token: 0x060076A6 RID: 30374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076A6")]
		[Address(RVA = "0x1FB2940", Offset = "0x1FB2940", VA = "0x7BBC7B2940")]
		private void OnClickBuyBuff()
		{
		}

		// Token: 0x060076A7 RID: 30375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076A7")]
		[Address(RVA = "0x1FB2D40", Offset = "0x1FB2D40", VA = "0x7BBC7B2D40", Slot = "46")]
		public override void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060076A8 RID: 30376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076A8")]
		[Address(RVA = "0x1FB2DAC", Offset = "0x1FB2DAC", VA = "0x7BBC7B2DAC", Slot = "37")]
		public override void OnPurchaseResult(bool isSuccess)
		{
		}

		// Token: 0x060076A9 RID: 30377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076A9")]
		[Address(RVA = "0x1FB3048", Offset = "0x1FB3048", VA = "0x7BBC7B3048", Slot = "38")]
		public override void OnSkipAnim()
		{
		}

		// Token: 0x060076AA RID: 30378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076AA")]
		[Address(RVA = "0x1FB304C", Offset = "0x1FB304C", VA = "0x7BBC7B304C", Slot = "34")]
		public override void OnHideContent()
		{
		}

		// Token: 0x060076AB RID: 30379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076AB")]
		[Address(RVA = "0x1FB309C", Offset = "0x1FB309C", VA = "0x7BBC7B309C", Slot = "35")]
		public override void OnShowContent()
		{
		}

		// Token: 0x060076AC RID: 30380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076AC")]
		[Address(RVA = "0x1FB1114", Offset = "0x1FB1114", VA = "0x7BBC7B1114")]
		public void ShowDrawResult(UIModelGacha.GachaDrawType dType, bool enableAnim = true)
		{
		}

		// Token: 0x060076AD RID: 30381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076AD")]
		[Address(RVA = "0x1FB3104", Offset = "0x1FB3104", VA = "0x7BBC7B3104")]
		private void OnCloseRewardPanel(params object[] param)
		{
		}

		// Token: 0x060076AE RID: 30382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076AE")]
		[Address(RVA = "0x1FB2F2C", Offset = "0x1FB2F2C", VA = "0x7BBC7B2F2C")]
		private void BeginPlaySingleDrawAnim()
		{
		}

		// Token: 0x060076AF RID: 30383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076AF")]
		[Address(RVA = "0x1FB30FC", Offset = "0x1FB30FC", VA = "0x7BBC7B30FC")]
		private void EndPlaySingleDrawAnim()
		{
		}

		// Token: 0x060076B0 RID: 30384 RVA: 0x00020DD8 File Offset: 0x0001EFD8
		[Token(Token = "0x60076B0")]
		[Address(RVA = "0x1FB3240", Offset = "0x1FB3240", VA = "0x7BBC7B3240", Slot = "29")]
		public new uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060076B1 RID: 30385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076B1")]
		[Address(RVA = "0x1FB3284", Offset = "0x1FB3284", VA = "0x7BBC7B3284", Slot = "31")]
		protected override void OnRefreshUIView()
		{
		}

		// Token: 0x060076B2 RID: 30386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076B2")]
		[Address(RVA = "0x1FB32EC", Offset = "0x1FB32EC", VA = "0x7BBC7B32EC")]
		public UIGachalegendaryContent()
		{
		}

		// Token: 0x04008D4D RID: 36173
		[Token(Token = "0x4008D4D")]
		[FieldOffset(Offset = "0x78")]
		private UIGachalegendaryContentView m_View;

		// Token: 0x04008D4E RID: 36174
		[Token(Token = "0x4008D4E")]
		[FieldOffset(Offset = "0x80")]
		private uint m_currentEnergyPoint;

		// Token: 0x04008D4F RID: 36175
		[Token(Token = "0x4008D4F")]
		[FieldOffset(Offset = "0x88")]
		private UIModelGacha m_ModelGacha;

		// Token: 0x04008D50 RID: 36176
		[Token(Token = "0x4008D50")]
		private const uint m_growupLuckPointTime = 1U;

		// Token: 0x04008D51 RID: 36177
		[Token(Token = "0x4008D51")]
		[FieldOffset(Offset = "0x90")]
		private CSSharedItemDataManager.StoreQuality m_CurrentDropQuality;

		// Token: 0x04008D52 RID: 36178
		[Token(Token = "0x4008D52")]
		[FieldOffset(Offset = "0x94")]
		private uint m_CurrentShowLevel;

		// Token: 0x04008D53 RID: 36179
		[Token(Token = "0x4008D53")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isShowGachaAnim;

		// Token: 0x020017ED RID: 6125
		[Token(Token = "0x20017ED")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F3194", Offset = "0x10F3194")]
		private sealed class <PlayEnergyProgressAnim>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060076B3 RID: 30387 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60076B3")]
			[Address(RVA = "0x1FB1AC4", Offset = "0x1FB1AC4", VA = "0x7BBC7B1AC4")]
			[DebuggerHidden]
			public <PlayEnergyProgressAnim>d__21(int <>1__state)
			{
			}

			// Token: 0x060076B4 RID: 30388 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60076B4")]
			[Address(RVA = "0x1FB32FC", Offset = "0x1FB32FC", VA = "0x7BBC7B32FC", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060076B5 RID: 30389 RVA: 0x00020DF0 File Offset: 0x0001EFF0
			[Token(Token = "0x60076B5")]
			[Address(RVA = "0x1FB3300", Offset = "0x1FB3300", VA = "0x7BBC7B3300", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000955 RID: 2389
			// (get) Token: 0x060076B6 RID: 30390 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000955")]
			private object Current
			{
				[Token(Token = "0x60076B6")]
				[Address(RVA = "0x1FB3644", Offset = "0x1FB3644", VA = "0x7BBC7B3644", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060076B7 RID: 30391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60076B7")]
			[Address(RVA = "0x1FB364C", Offset = "0x1FB364C", VA = "0x7BBC7B364C", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000956 RID: 2390
			// (get) Token: 0x060076B8 RID: 30392 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000956")]
			private object Current
			{
				[Token(Token = "0x60076B8")]
				[Address(RVA = "0x1FB36B4", Offset = "0x1FB36B4", VA = "0x7BBC7B36B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008D54 RID: 36180
			[Token(Token = "0x4008D54")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008D55 RID: 36181
			[Token(Token = "0x4008D55")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008D56 RID: 36182
			[Token(Token = "0x4008D56")]
			[FieldOffset(Offset = "0x20")]
			public UIGachalegendaryContent <>4__this;

			// Token: 0x04008D57 RID: 36183
			[Token(Token = "0x4008D57")]
			[FieldOffset(Offset = "0x28")]
			public uint startPoint;

			// Token: 0x04008D58 RID: 36184
			[Token(Token = "0x4008D58")]
			[FieldOffset(Offset = "0x2C")]
			public uint endPoint;

			// Token: 0x04008D59 RID: 36185
			[Token(Token = "0x4008D59")]
			[FieldOffset(Offset = "0x30")]
			private float <start_value>5__2;

			// Token: 0x04008D5A RID: 36186
			[Token(Token = "0x4008D5A")]
			[FieldOffset(Offset = "0x34")]
			private float <perTimeChange>5__3;

			// Token: 0x04008D5B RID: 36187
			[Token(Token = "0x4008D5B")]
			[FieldOffset(Offset = "0x38")]
			private float <cur_time>5__4;
		}
	}
}
