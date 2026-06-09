using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001691 RID: 5777
	[Token(Token = "0x2001691")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0594", Offset = "0x10F0594")]
	public class UITutorialIndicatorController : UIBaseController
	{
		// Token: 0x060068F6 RID: 26870 RVA: 0x0001DBF8 File Offset: 0x0001BDF8
		[Token(Token = "0x60068F6")]
		[Address(RVA = "0x19F82EC", Offset = "0x19F82EC", VA = "0x7BBC1F82EC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060068F7 RID: 26871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F7")]
		[Address(RVA = "0x19F833C", Offset = "0x19F833C", VA = "0x7BBC1F833C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060068F8 RID: 26872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F8")]
		[Address(RVA = "0x19F8474", Offset = "0x19F8474", VA = "0x7BBC1F8474", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060068F9 RID: 26873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068F9")]
		[Address(RVA = "0x19F8594", Offset = "0x19F8594", VA = "0x7BBC1F8594", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x060068FA RID: 26874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068FA")]
		[Address(RVA = "0x19F8844", Offset = "0x19F8844", VA = "0x7BBC1F8844")]
		public void Reset()
		{
		}

		// Token: 0x060068FB RID: 26875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068FB")]
		[Address(RVA = "0x19F85BC", Offset = "0x19F85BC", VA = "0x7BBC1F85BC")]
		private void ResetChilds()
		{
		}

		// Token: 0x060068FC RID: 26876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068FC")]
		[Address(RVA = "0x19F8A8C", Offset = "0x19F8A8C", VA = "0x7BBC1F8A8C")]
		public void ShowTutorialAtPosition(Transform showTrans, TutorialSetting tutSetting)
		{
		}

		// Token: 0x060068FD RID: 26877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068FD")]
		[Address(RVA = "0x19FA0D0", Offset = "0x19FA0D0", VA = "0x7BBC1FA0D0")]
		public void UpdatePosition(Transform showTrans)
		{
		}

		// Token: 0x060068FE RID: 26878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068FE")]
		[Address(RVA = "0x19FA174", Offset = "0x19FA174", VA = "0x7BBC1FA174")]
		public void UpdateWholePosition(Transform showTrans)
		{
		}

		// Token: 0x060068FF RID: 26879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068FF")]
		[Address(RVA = "0x19FA504", Offset = "0x19FA504", VA = "0x7BBC1FA504")]
		private void Update()
		{
		}

		// Token: 0x06006900 RID: 26880 RVA: 0x0001DC10 File Offset: 0x0001BE10
		[Token(Token = "0x6006900")]
		[Address(RVA = "0x19F9598", Offset = "0x19F9598", VA = "0x7BBC1F9598")]
		private Quadrant GetQuadrant(Vector3 position)
		{
			return Quadrant.First;
		}

		// Token: 0x06006901 RID: 26881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006901")]
		[Address(RVA = "0x19F984C", Offset = "0x19F984C", VA = "0x7BBC1F984C")]
		private void RotateCircleWithLineForQuadrant(Quadrant quadrant)
		{
		}

		// Token: 0x06006902 RID: 26882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006902")]
		[Address(RVA = "0x19F96A8", Offset = "0x19F96A8", VA = "0x7BBC1F96A8")]
		private void RotateCircleWithArrowForQuadrant(Quadrant quadrant, bool isMapCircle = false)
		{
		}

		// Token: 0x06006903 RID: 26883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006903")]
		[Address(RVA = "0x19F9A0C", Offset = "0x19F9A0C", VA = "0x7BBC1F9A0C")]
		private void SetHintTextTransform(float textWidth, Quadrant quadrant, TutorialUIType hintType)
		{
		}

		// Token: 0x06006904 RID: 26884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006904")]
		[Address(RVA = "0x19F9EB4", Offset = "0x19F9EB4", VA = "0x7BBC1F9EB4")]
		private void SetButtonClickEventDelegate(Transform buttonTransform)
		{
		}

		// Token: 0x06006905 RID: 26885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006905")]
		[Address(RVA = "0x19F88CC", Offset = "0x19F88CC", VA = "0x7BBC1F88CC")]
		private void RemoveButtonClickEventDelegate(Transform buttonTransform)
		{
		}

		// Token: 0x06006906 RID: 26886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006906")]
		[Address(RVA = "0x19FA5C4", Offset = "0x19FA5C4", VA = "0x7BBC1FA5C4")]
		private void FinishCurrentTuto()
		{
		}

		// Token: 0x06006907 RID: 26887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006907")]
		[Address(RVA = "0x19FA664", Offset = "0x19FA664", VA = "0x7BBC1FA664")]
		public void FinishCurrentTutorial(params object[] param)
		{
		}

		// Token: 0x06006908 RID: 26888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006908")]
		[Address(RVA = "0x19FA704", Offset = "0x19FA704", VA = "0x7BBC1FA704")]
		public UITutorialIndicatorController()
		{
		}

		// Token: 0x0400860C RID: 34316
		[Token(Token = "0x400860C")]
		[FieldOffset(Offset = "0x58")]
		private UITutorialIndicatorView m_View;

		// Token: 0x0400860D RID: 34317
		[Token(Token = "0x400860D")]
		private const float IndicatorWidth = 35f;

		// Token: 0x0400860E RID: 34318
		[Token(Token = "0x400860E")]
		private const float MapCircleWidth = 75f;

		// Token: 0x0400860F RID: 34319
		[Token(Token = "0x400860F")]
		private const float SmallCircleWidth = 90f;

		// Token: 0x04008610 RID: 34320
		[Token(Token = "0x4008610")]
		private const float LineWidth = 165f;

		// Token: 0x04008611 RID: 34321
		[Token(Token = "0x4008611")]
		private const float LineHight = 105f;

		// Token: 0x04008612 RID: 34322
		[Token(Token = "0x4008612")]
		[FieldOffset(Offset = "0x60")]
		private TutorialSetting m_TutSetting;

		// Token: 0x04008613 RID: 34323
		[Token(Token = "0x4008613")]
		[FieldOffset(Offset = "0x68")]
		private Transform m_ButtonTrans;

		// Token: 0x04008614 RID: 34324
		[Token(Token = "0x4008614")]
		[FieldOffset(Offset = "0x70")]
		private EventDelegate m_TmpClickEvent;

		// Token: 0x04008615 RID: 34325
		[Token(Token = "0x4008615")]
		[FieldOffset(Offset = "0x78")]
		private float m_CachTextWidth;

		// Token: 0x04008616 RID: 34326
		[Token(Token = "0x4008616")]
		[FieldOffset(Offset = "0x7C")]
		private Quadrant m_CachQuadrant;

		// Token: 0x04008617 RID: 34327
		[Token(Token = "0x4008617")]
		[FieldOffset(Offset = "0x80")]
		private TutorialUIType m_CachHintType;
	}
}
