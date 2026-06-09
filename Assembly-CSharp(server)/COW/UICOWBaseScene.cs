using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002068 RID: 8296
	[Token(Token = "0x2002068")]
	internal class UICOWBaseScene : UIBaseScene
	{
		// Token: 0x0600B8DA RID: 47322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8DA")]
		[Address(RVA = "0x1C1EC90", Offset = "0x1C1EC90", VA = "0x7BBC41EC90")]
		public UICOWBaseScene()
		{
		}

		// Token: 0x0600B8DB RID: 47323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8DB")]
		[Address(RVA = "0x1C1ED4C", Offset = "0x1C1ED4C", VA = "0x7BBC41ED4C", Slot = "8")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600B8DC RID: 47324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8DC")]
		[Address(RVA = "0x1C1ED54", Offset = "0x1C1ED54", VA = "0x7BBC41ED54", Slot = "9")]
		protected override void OnDestory()
		{
		}

		// Token: 0x0600B8DD RID: 47325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8DD")]
		[Address(RVA = "0x1C1EDC8", Offset = "0x1C1EDC8", VA = "0x7BBC41EDC8")]
		public void ShowStandardMessageBox(string info, UIPopupMessageBoxController.EStandardMessageBoxType mbType, [Optional] Action onOK, [Optional] Action onCancel, UIPopupMessageBoxController.EButtonStyle buttonStyle = UIPopupMessageBoxController.EButtonStyle.OKOnly, string note = "")
		{
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x0600B8DE RID: 47326 RVA: 0x00034D28 File Offset: 0x00032F28
		[Token(Token = "0x17000CB6")]
		public bool ShowingShareImageFileMessageBox
		{
			[Token(Token = "0x600B8DE")]
			[Address(RVA = "0x1C1EF38", Offset = "0x1C1EF38", VA = "0x7BBC41EF38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600B8DF RID: 47327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8DF")]
		[Address(RVA = "0x1C1EFA8", Offset = "0x1C1EFA8", VA = "0x7BBC41EFA8")]
		public void ShowShareImageFileMessageBox(UIBaseController target, ShareImageData data, [Optional] Action onClose, uint changedepth = 0U)
		{
		}

		// Token: 0x0600B8E0 RID: 47328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8E0")]
		[Address(RVA = "0x1C1F1FC", Offset = "0x1C1F1FC", VA = "0x7BBC41F1FC")]
		public void ShowNetworkErrorMessageBox()
		{
		}

		// Token: 0x0600B8E1 RID: 47329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B8E1")]
		[Address(RVA = "0x1C1F2DC", Offset = "0x1C1F2DC", VA = "0x7BBC41F2DC")]
		public UICOWBaseScene.Wait GetWait(UICOWBaseScene.WaitFor reason)
		{
			return null;
		}

		// Token: 0x0600B8E2 RID: 47330 RVA: 0x00034D40 File Offset: 0x00032F40
		[Token(Token = "0x600B8E2")]
		[Address(RVA = "0x1C1F384", Offset = "0x1C1F384", VA = "0x7BBC41F384")]
		public int GetWaitingCout()
		{
			return 0;
		}

		// Token: 0x0600B8E3 RID: 47331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8E3")]
		[Address(RVA = "0x1C1F3E4", Offset = "0x1C1F3E4", VA = "0x7BBC41F3E4")]
		public void ShowWaiting(UICOWBaseScene.WaitFor reason, UICOWBaseScene.Wait wait)
		{
		}

		// Token: 0x0600B8E4 RID: 47332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8E4")]
		[Address(RVA = "0x1C1F77C", Offset = "0x1C1F77C", VA = "0x7BBC41F77C")]
		public void HideWaiting(UICOWBaseScene.WaitFor reason)
		{
		}

		// Token: 0x0600B8E5 RID: 47333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8E5")]
		[Address(RVA = "0x1C1F790", Offset = "0x1C1F790", VA = "0x7BBC41F790")]
		public void PrintWaiting()
		{
		}

		// Token: 0x0600B8E6 RID: 47334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8E6")]
		[Address(RVA = "0x1C1F3FC", Offset = "0x1C1F3FC", VA = "0x7BBC41F3FC")]
		private void _SetWaitingUI(bool value, UICOWBaseScene.WaitFor reason, UICOWBaseScene.Wait wait)
		{
		}

		// Token: 0x0600B8E7 RID: 47335 RVA: 0x00034D58 File Offset: 0x00032F58
		[Token(Token = "0x600B8E7")]
		[Address(RVA = "0x1C1F9D0", Offset = "0x1C1F9D0", VA = "0x7BBC41F9D0")]
		public bool HasPopupBox()
		{
			return default(bool);
		}

		// Token: 0x0600B8E8 RID: 47336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8E8")]
		[Address(RVA = "0x1C1FA40", Offset = "0x1C1FA40", VA = "0x7BBC41FA40")]
		public void ClosePopupBox()
		{
		}

		// Token: 0x0600B8E9 RID: 47337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8E9")]
		[Address(RVA = "0x1C1FAD8", Offset = "0x1C1FAD8", VA = "0x7BBC41FAD8")]
		public void SetMask(bool mask, Color color)
		{
		}

		// Token: 0x0600B8EA RID: 47338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B8EA")]
		public override T PushNavigation<T>(UINavigationData navigationData, bool isRoot = false)
		{
			return null;
		}

		// Token: 0x0600B8EB RID: 47339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8EB")]
		[Address(RVA = "0x1C1FC90", Offset = "0x1C1FC90", VA = "0x7BBC41FC90")]
		public void TakeScreenshot(string filePath, UIUtils.ScreenshotType screenshotType, UIBaseController target, bool hasTopBar = true, bool hasLeftBar = true, UIUtils.EShareScreenType screenType = UIUtils.EShareScreenType.LandScape, float logoScale = 1f, bool hideUserID = false)
		{
		}

		// Token: 0x0600B8EC RID: 47340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B8EC")]
		[Address(RVA = "0x1C1FDB4", Offset = "0x1C1FDB4", VA = "0x7BBC41FDB4")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1147958", Offset = "0x1147958")]
		private IEnumerator _TakeScreenshot(string filePath, UIUtils.ScreenshotType screenshotType, UIBaseController target, bool hasTopBar, bool hasLeftBar = true, UIUtils.EShareScreenType screenType = UIUtils.EShareScreenType.LandScape, float logoScale = 1f, bool hideUserID = false)
		{
			return null;
		}

		// Token: 0x0600B8ED RID: 47341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B8ED")]
		[Address(RVA = "0x1C1FF48", Offset = "0x1C1FF48", VA = "0x7BBC41FF48")]
		public void TakeScreenshotWithAction(string filePath, UIUtils.ScreenshotType screenshotType, UIBaseController target, bool hasTopBar = true, [Optional] Action onClose, bool hasLeftBar = true, UIUtils.EShareScreenType screenType = UIUtils.EShareScreenType.LandScape, bool hideUserID = false)
		{
		}

		// Token: 0x0600B8EE RID: 47342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B8EE")]
		[Address(RVA = "0x1C20068", Offset = "0x1C20068", VA = "0x7BBC420068")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11479BC", Offset = "0x11479BC")]
		private IEnumerator _TakeScreenshotAction(string filePath, UIUtils.ScreenshotType screenshotType, UIBaseController target, bool hasTopBar, [Optional] Action onClose, bool hasLeftBar = true, UIUtils.EShareScreenType screenType = UIUtils.EShareScreenType.LandScape, bool hideUserID = false)
		{
			return null;
		}

		// Token: 0x0400BA85 RID: 47749
		[Token(Token = "0x400BA85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UIWaitingForRequestController m_WaitingForRequestController;

		// Token: 0x0400BA86 RID: 47750
		[Token(Token = "0x400BA86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private UIPopupMessageBoxController m_PopupMessageController;

		// Token: 0x0400BA87 RID: 47751
		[Token(Token = "0x400BA87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UIImageSharePreviewWindowController m_ImageSharePreviewWindowController;

		// Token: 0x0400BA88 RID: 47752
		[Token(Token = "0x400BA88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected UIMaskController m_MaskController;

		// Token: 0x0400BA89 RID: 47753
		[Token(Token = "0x400BA89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Dictionary<UICOWBaseScene.WaitFor, UICOWBaseScene.Wait> _Waits;

		// Token: 0x02002069 RID: 8297
		[Token(Token = "0x2002069")]
		public enum WaitFor
		{
			// Token: 0x0400BA8B RID: 47755
			[Token(Token = "0x400BA8B")]
			Default,
			// Token: 0x0400BA8C RID: 47756
			[Token(Token = "0x400BA8C")]
			GMSDK,
			// Token: 0x0400BA8D RID: 47757
			[Token(Token = "0x400BA8D")]
			IAP,
			// Token: 0x0400BA8E RID: 47758
			[Token(Token = "0x400BA8E")]
			HTTP,
			// Token: 0x0400BA8F RID: 47759
			[Token(Token = "0x400BA8F")]
			MatchRequest,
			// Token: 0x0400BA90 RID: 47760
			[Token(Token = "0x400BA90")]
			MatchResult,
			// Token: 0x0400BA91 RID: 47761
			[Token(Token = "0x400BA91")]
			CreateRoom,
			// Token: 0x0400BA92 RID: 47762
			[Token(Token = "0x400BA92")]
			TraceRoute,
			// Token: 0x0400BA93 RID: 47763
			[Token(Token = "0x400BA93")]
			GoogleEngagementRewards,
			// Token: 0x0400BA94 RID: 47764
			[Token(Token = "0x400BA94")]
			LoginLoading
		}

		// Token: 0x0200206A RID: 8298
		[Token(Token = "0x200206A")]
		public class Wait
		{
			// Token: 0x0600B8EF RID: 47343 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B8EF")]
			[Address(RVA = "0x1C1F9C8", Offset = "0x1C1F9C8", VA = "0x7BBC41F9C8")]
			public Wait()
			{
			}

			// Token: 0x0400BA95 RID: 47765
			[Token(Token = "0x400BA95")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Log;

			// Token: 0x0400BA96 RID: 47766
			[Token(Token = "0x400BA96")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool Block;
		}

		// Token: 0x0200206B RID: 8299
		[Token(Token = "0x200206B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD984", Offset = "0x10FD984")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x0600B8F0 RID: 47344 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B8F0")]
			[Address(RVA = "0x1C1F1F4", Offset = "0x1C1F1F4", VA = "0x7BBC41F1F4")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x0600B8F1 RID: 47345 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B8F1")]
			[Address(RVA = "0x1C201F8", Offset = "0x1C201F8", VA = "0x7BBC4201F8")]
			internal void <ShowShareImageFileMessageBox>b__0()
			{
			}

			// Token: 0x0400BA97 RID: 47767
			[Token(Token = "0x400BA97")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UICOWBaseScene <>4__this;

			// Token: 0x0400BA98 RID: 47768
			[Token(Token = "0x400BA98")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action onClose;

			// Token: 0x0400BA99 RID: 47769
			[Token(Token = "0x400BA99")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIBaseController target;
		}

		// Token: 0x0200206C RID: 8300
		[Token(Token = "0x200206C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD994", Offset = "0x10FD994")]
		private sealed class <>c__DisplayClass26_0
		{
			// Token: 0x0600B8F2 RID: 47346 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B8F2")]
			[Address(RVA = "0x1C20258", Offset = "0x1C20258", VA = "0x7BBC420258")]
			public <>c__DisplayClass26_0()
			{
			}

			// Token: 0x0600B8F3 RID: 47347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B8F3")]
			[Address(RVA = "0x1C20260", Offset = "0x1C20260", VA = "0x7BBC420260")]
			internal void <_TakeScreenshot>b__0(bool saved)
			{
			}

			// Token: 0x0400BA9A RID: 47770
			[Token(Token = "0x400BA9A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UICOWBaseScene <>4__this;

			// Token: 0x0400BA9B RID: 47771
			[Token(Token = "0x400BA9B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIImageShareCaptureWidgetController shareCaptureWidget;

			// Token: 0x0400BA9C RID: 47772
			[Token(Token = "0x400BA9C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIBaseController target;

			// Token: 0x0400BA9D RID: 47773
			[Token(Token = "0x400BA9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UIUtils.ScreenshotType screenshotType;

			// Token: 0x0400BA9E RID: 47774
			[Token(Token = "0x400BA9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public bool hideUserID;

			// Token: 0x0400BA9F RID: 47775
			[Token(Token = "0x400BA9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string filePath;

			// Token: 0x0400BAA0 RID: 47776
			[Token(Token = "0x400BAA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public UIUtils.EShareScreenType screenType;
		}

		// Token: 0x0200206D RID: 8301
		[Token(Token = "0x200206D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD9A4", Offset = "0x10FD9A4")]
		private sealed class <_TakeScreenshot>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600B8F4 RID: 47348 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B8F4")]
			[Address(RVA = "0x1C1FF1C", Offset = "0x1C1FF1C", VA = "0x7BBC41FF1C")]
			[DebuggerHidden]
			public <_TakeScreenshot>d__26(int <>1__state)
			{
			}

			// Token: 0x0600B8F5 RID: 47349 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B8F5")]
			[Address(RVA = "0x1C209DC", Offset = "0x1C209DC", VA = "0x7BBC4209DC", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600B8F6 RID: 47350 RVA: 0x00034D70 File Offset: 0x00032F70
			[Token(Token = "0x600B8F6")]
			[Address(RVA = "0x1C209E0", Offset = "0x1C209E0", VA = "0x7BBC4209E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000CB7 RID: 3255
			// (get) Token: 0x0600B8F7 RID: 47351 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CB7")]
			private object Current
			{
				[Token(Token = "0x600B8F7")]
				[Address(RVA = "0x1C20FAC", Offset = "0x1C20FAC", VA = "0x7BBC420FAC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600B8F8 RID: 47352 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B8F8")]
			[Address(RVA = "0x1C20FB4", Offset = "0x1C20FB4", VA = "0x7BBC420FB4", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000CB8 RID: 3256
			// (get) Token: 0x0600B8F9 RID: 47353 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CB8")]
			private object Current
			{
				[Token(Token = "0x600B8F9")]
				[Address(RVA = "0x1C2101C", Offset = "0x1C2101C", VA = "0x7BBC42101C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400BAA1 RID: 47777
			[Token(Token = "0x400BAA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400BAA2 RID: 47778
			[Token(Token = "0x400BAA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400BAA3 RID: 47779
			[Token(Token = "0x400BAA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UICOWBaseScene <>4__this;

			// Token: 0x0400BAA4 RID: 47780
			[Token(Token = "0x400BAA4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UIBaseController target;

			// Token: 0x0400BAA5 RID: 47781
			[Token(Token = "0x400BAA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UIUtils.ScreenshotType screenshotType;

			// Token: 0x0400BAA6 RID: 47782
			[Token(Token = "0x400BAA6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool hideUserID;

			// Token: 0x0400BAA7 RID: 47783
			[Token(Token = "0x400BAA7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string filePath;

			// Token: 0x0400BAA8 RID: 47784
			[Token(Token = "0x400BAA8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public UIUtils.EShareScreenType screenType;

			// Token: 0x0400BAA9 RID: 47785
			[Token(Token = "0x400BAA9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool hasTopBar;

			// Token: 0x0400BAAA RID: 47786
			[Token(Token = "0x400BAAA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
			public bool hasLeftBar;

			// Token: 0x0400BAAB RID: 47787
			[Token(Token = "0x400BAAB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float logoScale;

			// Token: 0x0400BAAC RID: 47788
			[Token(Token = "0x400BAAC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UICOWBaseScene.<>c__DisplayClass26_0 <>8__1;

			// Token: 0x0400BAAD RID: 47789
			[Token(Token = "0x400BAAD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private bool <NeedRotationResultPic>5__2;
		}

		// Token: 0x0200206E RID: 8302
		[Token(Token = "0x200206E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD9B4", Offset = "0x10FD9B4")]
		private sealed class <>c__DisplayClass28_0
		{
			// Token: 0x0600B8FA RID: 47354 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B8FA")]
			[Address(RVA = "0x1C20618", Offset = "0x1C20618", VA = "0x7BBC420618")]
			public <>c__DisplayClass28_0()
			{
			}

			// Token: 0x0600B8FB RID: 47355 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B8FB")]
			[Address(RVA = "0x1C20620", Offset = "0x1C20620", VA = "0x7BBC420620")]
			internal void <_TakeScreenshotAction>b__0(bool saved)
			{
			}

			// Token: 0x0400BAAE RID: 47790
			[Token(Token = "0x400BAAE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UICOWBaseScene <>4__this;

			// Token: 0x0400BAAF RID: 47791
			[Token(Token = "0x400BAAF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIImageShareCaptureWidgetController shareCaptureWidget;

			// Token: 0x0400BAB0 RID: 47792
			[Token(Token = "0x400BAB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UIBaseController target;

			// Token: 0x0400BAB1 RID: 47793
			[Token(Token = "0x400BAB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UIUtils.ScreenshotType screenshotType;

			// Token: 0x0400BAB2 RID: 47794
			[Token(Token = "0x400BAB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public bool hideUserID;

			// Token: 0x0400BAB3 RID: 47795
			[Token(Token = "0x400BAB3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string filePath;

			// Token: 0x0400BAB4 RID: 47796
			[Token(Token = "0x400BAB4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public UIUtils.EShareScreenType screenType;

			// Token: 0x0400BAB5 RID: 47797
			[Token(Token = "0x400BAB5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action onClose;
		}

		// Token: 0x0200206F RID: 8303
		[Token(Token = "0x200206F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD9C4", Offset = "0x10FD9C4")]
		private sealed class <_TakeScreenshotAction>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600B8FC RID: 47356 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B8FC")]
			[Address(RVA = "0x1C201CC", Offset = "0x1C201CC", VA = "0x7BBC4201CC")]
			[DebuggerHidden]
			public <_TakeScreenshotAction>d__28(int <>1__state)
			{
			}

			// Token: 0x0600B8FD RID: 47357 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B8FD")]
			[Address(RVA = "0x1C21024", Offset = "0x1C21024", VA = "0x7BBC421024", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600B8FE RID: 47358 RVA: 0x00034D88 File Offset: 0x00032F88
			[Token(Token = "0x600B8FE")]
			[Address(RVA = "0x1C21028", Offset = "0x1C21028", VA = "0x7BBC421028", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000CB9 RID: 3257
			// (get) Token: 0x0600B8FF RID: 47359 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CB9")]
			private object Current
			{
				[Token(Token = "0x600B8FF")]
				[Address(RVA = "0x1C21608", Offset = "0x1C21608", VA = "0x7BBC421608", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600B900 RID: 47360 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B900")]
			[Address(RVA = "0x1C21610", Offset = "0x1C21610", VA = "0x7BBC421610", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000CBA RID: 3258
			// (get) Token: 0x0600B901 RID: 47361 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CBA")]
			private object Current
			{
				[Token(Token = "0x600B901")]
				[Address(RVA = "0x1C21678", Offset = "0x1C21678", VA = "0x7BBC421678", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400BAB6 RID: 47798
			[Token(Token = "0x400BAB6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400BAB7 RID: 47799
			[Token(Token = "0x400BAB7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400BAB8 RID: 47800
			[Token(Token = "0x400BAB8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UICOWBaseScene <>4__this;

			// Token: 0x0400BAB9 RID: 47801
			[Token(Token = "0x400BAB9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UIBaseController target;

			// Token: 0x0400BABA RID: 47802
			[Token(Token = "0x400BABA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public UIUtils.ScreenshotType screenshotType;

			// Token: 0x0400BABB RID: 47803
			[Token(Token = "0x400BABB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool hideUserID;

			// Token: 0x0400BABC RID: 47804
			[Token(Token = "0x400BABC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string filePath;

			// Token: 0x0400BABD RID: 47805
			[Token(Token = "0x400BABD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public UIUtils.EShareScreenType screenType;

			// Token: 0x0400BABE RID: 47806
			[Token(Token = "0x400BABE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Action onClose;

			// Token: 0x0400BABF RID: 47807
			[Token(Token = "0x400BABF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool hasTopBar;

			// Token: 0x0400BAC0 RID: 47808
			[Token(Token = "0x400BAC0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
			public bool hasLeftBar;

			// Token: 0x0400BAC1 RID: 47809
			[Token(Token = "0x400BAC1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private UICOWBaseScene.<>c__DisplayClass28_0 <>8__1;

			// Token: 0x0400BAC2 RID: 47810
			[Token(Token = "0x400BAC2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool <NeedRotationResultPic>5__2;
		}
	}
}
