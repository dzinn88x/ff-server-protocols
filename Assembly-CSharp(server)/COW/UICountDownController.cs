using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200176B RID: 5995
	[Token(Token = "0x200176B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2064", Offset = "0x10F2064")]
	public class UICountDownController : UIBaseController
	{
		// Token: 0x06007115 RID: 28949 RVA: 0x0001F9C8 File Offset: 0x0001DBC8
		[Token(Token = "0x6007115")]
		[Address(RVA = "0x1817AA0", Offset = "0x1817AA0", VA = "0x7BBC017AA0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007116 RID: 28950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007116")]
		[Address(RVA = "0x1817AF0", Offset = "0x1817AF0", VA = "0x7BBC017AF0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007117 RID: 28951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007117")]
		[Address(RVA = "0x1817C64", Offset = "0x1817C64", VA = "0x7BBC017C64")]
		public void SetIconShow(bool show)
		{
		}

		// Token: 0x06007118 RID: 28952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007118")]
		[Address(RVA = "0x1817CD8", Offset = "0x1817CD8", VA = "0x7BBC017CD8")]
		public void RefreshCountDown(ulong end, string prefix = "", string suffix = "", bool formated = true, [Optional] OnStarted onStarted, [Optional] OnFinished onFinished, bool isStarted = true)
		{
		}

		// Token: 0x06007119 RID: 28953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007119")]
		[Address(RVA = "0x1817EBC", Offset = "0x1817EBC", VA = "0x7BBC017EBC")]
		public void SetStyle(UICountDownController.AlignmentType alignmentType = UICountDownController.AlignmentType.LEFT, UICountDownController.IconType iconType = UICountDownController.IconType.TIME1, UILabel.Effect labelStyle = UILabel.Effect.Shadow, bool applyGradient = false, uint gradientTop = 16777215U, uint gradientBottom = 0U)
		{
		}

		// Token: 0x0600711A RID: 28954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600711A")]
		[Address(RVA = "0x1818534", Offset = "0x1818534", VA = "0x7BBC018534")]
		public void SetAlpha(float alpha)
		{
		}

		// Token: 0x0600711B RID: 28955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600711B")]
		[Address(RVA = "0x18185EC", Offset = "0x18185EC", VA = "0x7BBC0185EC")]
		public void SetFontSize(int size)
		{
		}

		// Token: 0x0600711C RID: 28956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600711C")]
		[Address(RVA = "0x1818624", Offset = "0x1818624", VA = "0x7BBC018624")]
		public void SetFontStyle(FontStyle style)
		{
		}

		// Token: 0x0600711D RID: 28957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600711D")]
		[Address(RVA = "0x181865C", Offset = "0x181865C", VA = "0x7BBC01865C")]
		public void SetColor(Color color)
		{
		}

		// Token: 0x0600711E RID: 28958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600711E")]
		[Address(RVA = "0x18186FC", Offset = "0x18186FC", VA = "0x7BBC0186FC")]
		public void SetColor(uint color)
		{
		}

		// Token: 0x0600711F RID: 28959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600711F")]
		[Address(RVA = "0x18184FC", Offset = "0x18184FC", VA = "0x7BBC0184FC")]
		public void SetLabelEffect(UILabel.Effect effectStyle)
		{
		}

		// Token: 0x06007120 RID: 28960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007120")]
		[Address(RVA = "0x18187D0", Offset = "0x18187D0", VA = "0x7BBC0187D0")]
		public void SetLabelEffectColor(Color color, Vector2 effectSize)
		{
		}

		// Token: 0x06007121 RID: 28961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007121")]
		[Address(RVA = "0x1818868", Offset = "0x1818868", VA = "0x7BBC018868")]
		public void SetLabelText(string text)
		{
		}

		// Token: 0x06007122 RID: 28962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007122")]
		[Address(RVA = "0x18188B0", Offset = "0x18188B0", VA = "0x7BBC0188B0")]
		public void ShowIcon(bool show = true)
		{
		}

		// Token: 0x06007123 RID: 28963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007123")]
		[Address(RVA = "0x1818910", Offset = "0x1818910", VA = "0x7BBC018910")]
		public void SetLabel(string value)
		{
		}

		// Token: 0x06007124 RID: 28964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007124")]
		[Address(RVA = "0x1818948", Offset = "0x1818948", VA = "0x7BBC018948")]
		public UILabel GetLabel()
		{
			return null;
		}

		// Token: 0x06007125 RID: 28965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007125")]
		[Address(RVA = "0x1818950", Offset = "0x1818950", VA = "0x7BBC018950")]
		public void Cancel()
		{
		}

		// Token: 0x06007126 RID: 28966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007126")]
		[Address(RVA = "0x1818A04", Offset = "0x1818A04", VA = "0x7BBC018A04")]
		public void SetCountDownIconClickCallback(Action callback)
		{
		}

		// Token: 0x06007127 RID: 28967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007127")]
		[Address(RVA = "0x1818AF8", Offset = "0x1818AF8", VA = "0x7BBC018AF8")]
		private void OnCountDownIconClick()
		{
		}

		// Token: 0x06007128 RID: 28968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007128")]
		[Address(RVA = "0x1818B0C", Offset = "0x1818B0C", VA = "0x7BBC018B0C")]
		public void SetDepth(int depth)
		{
		}

		// Token: 0x06007129 RID: 28969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007129")]
		[Address(RVA = "0x1818B90", Offset = "0x1818B90", VA = "0x7BBC018B90")]
		public UICountDownController()
		{
		}

		// Token: 0x04008ABF RID: 35519
		[Token(Token = "0x4008ABF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<UICountDownController.IconType, string> m_IconDict;

		// Token: 0x04008AC0 RID: 35520
		[Token(Token = "0x4008AC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UICountDownView m_View;

		// Token: 0x04008AC1 RID: 35521
		[Token(Token = "0x4008AC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private UILabel m_UILabel;

		// Token: 0x04008AC2 RID: 35522
		[Token(Token = "0x4008AC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Action m_CountDownIconClickHandler;

		// Token: 0x0200176C RID: 5996
		[Token(Token = "0x200176C")]
		public enum AlignmentType
		{
			// Token: 0x04008AC4 RID: 35524
			[Token(Token = "0x4008AC4")]
			LEFT,
			// Token: 0x04008AC5 RID: 35525
			[Token(Token = "0x4008AC5")]
			CENTER,
			// Token: 0x04008AC6 RID: 35526
			[Token(Token = "0x4008AC6")]
			RIGHT
		}

		// Token: 0x0200176D RID: 5997
		[Token(Token = "0x200176D")]
		public enum IconType
		{
			// Token: 0x04008AC8 RID: 35528
			[Token(Token = "0x4008AC8")]
			TIME1,
			// Token: 0x04008AC9 RID: 35529
			[Token(Token = "0x4008AC9")]
			TIME2
		}
	}
}
