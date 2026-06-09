using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001747 RID: 5959
	[Token(Token = "0x2001747")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1D9C", Offset = "0x10F1D9C")]
	public class UICommonGuideController : UIBaseController
	{
		// Token: 0x06007021 RID: 28705 RVA: 0x0001F668 File Offset: 0x0001D868
		[Token(Token = "0x6007021")]
		[Address(RVA = "0x1800058", Offset = "0x1800058", VA = "0x7BBC000058")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007022 RID: 28706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007022")]
		[Address(RVA = "0x18000A8", Offset = "0x18000A8", VA = "0x7BBC0000A8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007023 RID: 28707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007023")]
		[Address(RVA = "0x180080C", Offset = "0x180080C", VA = "0x7BBC00080C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007024 RID: 28708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007024")]
		[Address(RVA = "0x1800884", Offset = "0x1800884", VA = "0x7BBC000884")]
		public void SetGuideInfo(UIWidget widget, EGuideStyle style, string guideType, string text = "", float duraction = 4f, EGuideStyle reviseStyle = EGuideStyle.Center)
		{
		}

		// Token: 0x06007025 RID: 28709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007025")]
		[Address(RVA = "0x18009B8", Offset = "0x18009B8", VA = "0x7BBC0009B8")]
		public void SetGuideInfo(UIWidget widget, float scaleRatio, EGuideStyle style, string guideType, string text = "", float duraction = 4f, EGuideStyle reviseStyle = EGuideStyle.Center)
		{
		}

		// Token: 0x06007026 RID: 28710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007026")]
		[Address(RVA = "0x1800AF0", Offset = "0x1800AF0", VA = "0x7BBC000AF0")]
		public UIWidget GetCircleWidget()
		{
			return null;
		}

		// Token: 0x06007027 RID: 28711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007027")]
		[Address(RVA = "0x1800AA4", Offset = "0x1800AA4", VA = "0x7BBC000AA4")]
		[Attribute(Name = "ContextMenu", RVA = "0x11414E0", Offset = "0x11414E0")]
		private void RefreshView()
		{
		}

		// Token: 0x06007028 RID: 28712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007028")]
		[Address(RVA = "0x1800B1C", Offset = "0x1800B1C", VA = "0x7BBC000B1C")]
		public void SetEffectShow(bool flag)
		{
		}

		// Token: 0x06007029 RID: 28713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007029")]
		[Address(RVA = "0x1800B2C", Offset = "0x1800B2C", VA = "0x7BBC000B2C")]
		public void SetCircleShow(bool flag)
		{
		}

		// Token: 0x0600702A RID: 28714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600702A")]
		[Address(RVA = "0x1800B38", Offset = "0x1800B38", VA = "0x7BBC000B38")]
		public void SetArrowShow()
		{
		}

		// Token: 0x0600702B RID: 28715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600702B")]
		[Address(RVA = "0x1800B44", Offset = "0x1800B44", VA = "0x7BBC000B44")]
		public void AddCircleCallback(EventDelegate.Callback action)
		{
		}

		// Token: 0x0600702C RID: 28716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600702C")]
		[Address(RVA = "0x1800C18", Offset = "0x1800C18", VA = "0x7BBC000C18")]
		public void RemoveCircleCallback(EventDelegate.Callback action)
		{
		}

		// Token: 0x0600702D RID: 28717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600702D")]
		[Address(RVA = "0x1800CA4", Offset = "0x1800CA4", VA = "0x7BBC000CA4")]
		public void UpdateDepth(int newDepth)
		{
		}

		// Token: 0x0600702E RID: 28718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600702E")]
		[Address(RVA = "0x1800D1C", Offset = "0x1800D1C", VA = "0x7BBC000D1C")]
		public void ShowLongArrow()
		{
		}

		// Token: 0x0600702F RID: 28719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600702F")]
		[Address(RVA = "0x1800DBC", Offset = "0x1800DBC", VA = "0x7BBC000DBC")]
		public void SetCloseAction(Action action)
		{
		}

		// Token: 0x06007030 RID: 28720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007030")]
		[Address(RVA = "0x1800D48", Offset = "0x1800D48", VA = "0x7BBC000D48")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1141518", Offset = "0x1141518")]
		private IEnumerator SetArrow()
		{
			return null;
		}

		// Token: 0x06007031 RID: 28721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007031")]
		[Address(RVA = "0x1800DF0", Offset = "0x1800DF0", VA = "0x7BBC000DF0")]
		private void Update()
		{
		}

		// Token: 0x06007032 RID: 28722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007032")]
		[Address(RVA = "0x1801BEC", Offset = "0x1801BEC", VA = "0x7BBC001BEC", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06007033 RID: 28723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007033")]
		[Address(RVA = "0x1801C34", Offset = "0x1801C34", VA = "0x7BBC001C34")]
		private void OnClose()
		{
		}

		// Token: 0x06007034 RID: 28724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007034")]
		[Address(RVA = "0x18013AC", Offset = "0x18013AC", VA = "0x7BBC0013AC")]
		private void RefreshViewByStyle()
		{
		}

		// Token: 0x06007035 RID: 28725 RVA: 0x0001F680 File Offset: 0x0001D880
		[Token(Token = "0x6007035")]
		[Address(RVA = "0x1801C68", Offset = "0x1801C68", VA = "0x7BBC001C68")]
		private Vector3 CalculateGuideTextPos(UICommonGuideController.GuideStyle style, UICommonGuideController.GuideStyle reviseStyle)
		{
			return default(Vector3);
		}

		// Token: 0x06007036 RID: 28726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007036")]
		[Address(RVA = "0x1801374", Offset = "0x1801374", VA = "0x7BBC001374")]
		private void SetGuideStyle()
		{
		}

		// Token: 0x06007037 RID: 28727 RVA: 0x0001F698 File Offset: 0x0001D898
		[Token(Token = "0x6007037")]
		[Address(RVA = "0x1801F38", Offset = "0x1801F38", VA = "0x7BBC001F38")]
		private bool CheckExpectStyleIsAvailabel()
		{
			return default(bool);
		}

		// Token: 0x06007038 RID: 28728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007038")]
		[Address(RVA = "0x1801F40", Offset = "0x1801F40", VA = "0x7BBC001F40")]
		private void FindAvailableStyle()
		{
		}

		// Token: 0x06007039 RID: 28729 RVA: 0x0001F6B0 File Offset: 0x0001D8B0
		[Token(Token = "0x6007039")]
		[Address(RVA = "0x1802300", Offset = "0x1802300", VA = "0x7BBC002300")]
		private bool CheckStyleIsAvailable(EGuideStyle style, EGuideStyle reviseStyle)
		{
			return default(bool);
		}

		// Token: 0x0600703A RID: 28730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600703A")]
		[Address(RVA = "0x180121C", Offset = "0x180121C", VA = "0x7BBC00121C")]
		private void RevisePositionByPovit(UIWidget widget)
		{
		}

		// Token: 0x0600703B RID: 28731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600703B")]
		[Address(RVA = "0x180295C", Offset = "0x180295C", VA = "0x7BBC00295C")]
		public void SetCircleBtnDepth(int depth)
		{
		}

		// Token: 0x0600703C RID: 28732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600703C")]
		[Address(RVA = "0x18029A4", Offset = "0x18029A4", VA = "0x7BBC0029A4")]
		public UICommonGuideController()
		{
		}

		// Token: 0x04008A14 RID: 35348
		[Token(Token = "0x4008A14")]
		[FieldOffset(Offset = "0x58")]
		private UICommonGuideView m_View;

		// Token: 0x04008A15 RID: 35349
		[Token(Token = "0x4008A15")]
		[FieldOffset(Offset = "0x60")]
		public EGuideStyle m_Style;

		// Token: 0x04008A16 RID: 35350
		[Token(Token = "0x4008A16")]
		[FieldOffset(Offset = "0x64")]
		public EGuideStyle m_ReviseStyle;

		// Token: 0x04008A17 RID: 35351
		[Token(Token = "0x4008A17")]
		[FieldOffset(Offset = "0x68")]
		public string m_Text;

		// Token: 0x04008A18 RID: 35352
		[Token(Token = "0x4008A18")]
		[FieldOffset(Offset = "0x70")]
		public UIWidget m_Widget;

		// Token: 0x04008A19 RID: 35353
		[Token(Token = "0x4008A19")]
		[FieldOffset(Offset = "0x78")]
		public float m_ScaleRatio;

		// Token: 0x04008A1A RID: 35354
		[Token(Token = "0x4008A1A")]
		[FieldOffset(Offset = "0x7C")]
		public float m_Duraction;

		// Token: 0x04008A1B RID: 35355
		[Token(Token = "0x4008A1B")]
		[FieldOffset(Offset = "0x80")]
		private float m_CircleRadius;

		// Token: 0x04008A1C RID: 35356
		[Token(Token = "0x4008A1C")]
		[FieldOffset(Offset = "0x84")]
		private uint m_DelayCall;

		// Token: 0x04008A1D RID: 35357
		[Token(Token = "0x4008A1D")]
		[FieldOffset(Offset = "0x88")]
		private UIRoot m_UIRoot;

		// Token: 0x04008A1E RID: 35358
		[Token(Token = "0x4008A1E")]
		[FieldOffset(Offset = "0x90")]
		private Dictionary<EGuideStyle, UICommonGuideController.GuideStyle> m_GuideStyleDict;

		// Token: 0x04008A1F RID: 35359
		[Token(Token = "0x4008A1F")]
		[FieldOffset(Offset = "0x98")]
		private bool m_Inited;

		// Token: 0x04008A20 RID: 35360
		[Token(Token = "0x4008A20")]
		[FieldOffset(Offset = "0x99")]
		private bool m_NextFrame;

		// Token: 0x04008A21 RID: 35361
		[Token(Token = "0x4008A21")]
		[FieldOffset(Offset = "0x9A")]
		private bool m_NeedShowCircle;

		// Token: 0x04008A22 RID: 35362
		[Token(Token = "0x4008A22")]
		[FieldOffset(Offset = "0x9B")]
		private bool m_NeedShowArrow;

		// Token: 0x04008A23 RID: 35363
		[Token(Token = "0x4008A23")]
		[FieldOffset(Offset = "0xA0")]
		private UIButton m_CircleBtn;

		// Token: 0x04008A24 RID: 35364
		[Token(Token = "0x4008A24")]
		[FieldOffset(Offset = "0xA8")]
		private Action m_CloseAction;

		// Token: 0x02001748 RID: 5960
		[Token(Token = "0x2001748")]
		private class GuideStyle
		{
			// Token: 0x0600703D RID: 28733 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600703D")]
			[Address(RVA = "0x1802C18", Offset = "0x1802C18", VA = "0x7BBC002C18")]
			public GuideStyle()
			{
			}

			// Token: 0x04008A25 RID: 35365
			[Token(Token = "0x4008A25")]
			[FieldOffset(Offset = "0x10")]
			public int XPosFactor;

			// Token: 0x04008A26 RID: 35366
			[Token(Token = "0x4008A26")]
			[FieldOffset(Offset = "0x14")]
			public int YPosFactor;

			// Token: 0x04008A27 RID: 35367
			[Token(Token = "0x4008A27")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 ArrowRotation;

			// Token: 0x04008A28 RID: 35368
			[Token(Token = "0x4008A28")]
			[FieldOffset(Offset = "0x28")]
			public List<EGuideStyle> ReviseStyleList;
		}

		// Token: 0x02001749 RID: 5961
		[Token(Token = "0x2001749")]
		private class GuideStyleCenter : UICommonGuideController.GuideStyle
		{
			// Token: 0x0600703E RID: 28734 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600703E")]
			[Address(RVA = "0x18002E4", Offset = "0x18002E4", VA = "0x7BBC0002E4")]
			public GuideStyleCenter()
			{
			}
		}

		// Token: 0x0200174A RID: 5962
		[Token(Token = "0x200174A")]
		private class GuideStyleLeft : UICommonGuideController.GuideStyle
		{
			// Token: 0x0600703F RID: 28735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600703F")]
			[Address(RVA = "0x1800308", Offset = "0x1800308", VA = "0x7BBC000308")]
			public GuideStyleLeft()
			{
			}
		}

		// Token: 0x0200174B RID: 5963
		[Token(Token = "0x200174B")]
		private class GuideStyleRight : UICommonGuideController.GuideStyle
		{
			// Token: 0x06007040 RID: 28736 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007040")]
			[Address(RVA = "0x1800440", Offset = "0x1800440", VA = "0x7BBC000440")]
			public GuideStyleRight()
			{
			}
		}

		// Token: 0x0200174C RID: 5964
		[Token(Token = "0x200174C")]
		private class GuideStyleTop : UICommonGuideController.GuideStyle
		{
			// Token: 0x06007041 RID: 28737 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007041")]
			[Address(RVA = "0x1800584", Offset = "0x1800584", VA = "0x7BBC000584")]
			public GuideStyleTop()
			{
			}
		}

		// Token: 0x0200174D RID: 5965
		[Token(Token = "0x200174D")]
		private class GuideStyleBottom : UICommonGuideController.GuideStyle
		{
			// Token: 0x06007042 RID: 28738 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007042")]
			[Address(RVA = "0x18006C8", Offset = "0x18006C8", VA = "0x7BBC0006C8")]
			public GuideStyleBottom()
			{
			}
		}

		// Token: 0x0200174E RID: 5966
		[Token(Token = "0x200174E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F1DD4", Offset = "0x10F1DD4")]
		private sealed class <SetArrow>d__32 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06007043 RID: 28739 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007043")]
			[Address(RVA = "0x1800DC4", Offset = "0x1800DC4", VA = "0x7BBC000DC4")]
			[DebuggerHidden]
			public <SetArrow>d__32(int <>1__state)
			{
			}

			// Token: 0x06007044 RID: 28740 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007044")]
			[Address(RVA = "0x18029B4", Offset = "0x18029B4", VA = "0x7BBC0029B4", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06007045 RID: 28741 RVA: 0x0001F6C8 File Offset: 0x0001D8C8
			[Token(Token = "0x6007045")]
			[Address(RVA = "0x18029B8", Offset = "0x18029B8", VA = "0x7BBC0029B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700092F RID: 2351
			// (get) Token: 0x06007046 RID: 28742 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700092F")]
			private object Current
			{
				[Token(Token = "0x6007046")]
				[Address(RVA = "0x1802BA0", Offset = "0x1802BA0", VA = "0x7BBC002BA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06007047 RID: 28743 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007047")]
			[Address(RVA = "0x1802BA8", Offset = "0x1802BA8", VA = "0x7BBC002BA8", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000930 RID: 2352
			// (get) Token: 0x06007048 RID: 28744 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000930")]
			private object Current
			{
				[Token(Token = "0x6007048")]
				[Address(RVA = "0x1802C10", Offset = "0x1802C10", VA = "0x7BBC002C10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04008A29 RID: 35369
			[Token(Token = "0x4008A29")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008A2A RID: 35370
			[Token(Token = "0x4008A2A")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008A2B RID: 35371
			[Token(Token = "0x4008A2B")]
			[FieldOffset(Offset = "0x20")]
			public UICommonGuideController <>4__this;
		}
	}
}
