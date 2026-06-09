using System;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001980 RID: 6528
	[Token(Token = "0x2001980")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F660C", Offset = "0x10F660C")]
	internal class UIHudTKWeaponInfoController : UIBaseController
	{
		// Token: 0x060084FE RID: 34046 RVA: 0x00024120 File Offset: 0x00022320
		[Token(Token = "0x60084FE")]
		[Address(RVA = "0x167B270", Offset = "0x167B270", VA = "0x7BBBE7B270")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060084FF RID: 34047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084FF")]
		[Address(RVA = "0x167B2C0", Offset = "0x167B2C0", VA = "0x7BBBE7B2C0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008500 RID: 34048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008500")]
		[Address(RVA = "0x167B654", Offset = "0x167B654", VA = "0x7BBBE7B654", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008501 RID: 34049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008501")]
		[Address(RVA = "0x167B870", Offset = "0x167B870", VA = "0x7BBBE7B870")]
		private void Update()
		{
		}

		// Token: 0x06008502 RID: 34050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008502")]
		[Address(RVA = "0x167C1F4", Offset = "0x167C1F4", VA = "0x7BBBE7C1F4")]
		private void OnLastWeaponInit(params object[] param)
		{
		}

		// Token: 0x06008503 RID: 34051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008503")]
		[Address(RVA = "0x167C2F4", Offset = "0x167C2F4", VA = "0x7BBBE7C2F4")]
		private void OnInventoryItemChanged(params object[] param)
		{
		}

		// Token: 0x06008504 RID: 34052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008504")]
		[Address(RVA = "0x167C3B8", Offset = "0x167C3B8", VA = "0x7BBBE7C3B8")]
		private void OnThrowKnifePhaseChanged(params object[] param)
		{
		}

		// Token: 0x06008505 RID: 34053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008505")]
		[Address(RVA = "0x167BEBC", Offset = "0x167BEBC", VA = "0x7BBBE7BEBC")]
		private void SetProgressBarAndCntUI(bool equipThrowKnife, int cnt)
		{
		}

		// Token: 0x06008506 RID: 34054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008506")]
		[Address(RVA = "0x167C44C", Offset = "0x167C44C", VA = "0x7BBBE7C44C")]
		private void OnShowKnifeAutoGenTutorial(object[] data)
		{
		}

		// Token: 0x06008507 RID: 34055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008507")]
		[Address(RVA = "0x167C650", Offset = "0x167C650", VA = "0x7BBBE7C650")]
		private void OnObserverInfoListVisibleChanged(object[] data)
		{
		}

		// Token: 0x06008508 RID: 34056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008508")]
		[Address(RVA = "0x167C6F8", Offset = "0x167C6F8", VA = "0x7BBBE7C6F8")]
		public UIHudTKWeaponInfoController()
		{
		}

		// Token: 0x06008509 RID: 34057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008509")]
		[Address(RVA = "0x167C700", Offset = "0x167C700", VA = "0x7BBBE7C700")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143448", Offset = "0x1143448")]
		private void <OnUIInit>b__7_0()
		{
		}

		// Token: 0x040094DB RID: 38107
		[Token(Token = "0x40094DB")]
		[FieldOffset(Offset = "0x58")]
		private UIHudTKWeaponInfoView m_View;

		// Token: 0x040094DC RID: 38108
		[Token(Token = "0x40094DC")]
		[FieldOffset(Offset = "0x60")]
		private ytMNhlw m_LastWeaponInHand;

		// Token: 0x040094DD RID: 38109
		[Token(Token = "0x40094DD")]
		[FieldOffset(Offset = "0x68")]
		private bool m_weaponChanged;

		// Token: 0x040094DE RID: 38110
		[Token(Token = "0x40094DE")]
		[FieldOffset(Offset = "0x70")]
		private StringBuilder m_Sb;

		// Token: 0x040094DF RID: 38111
		[Token(Token = "0x40094DF")]
		[FieldOffset(Offset = "0x78")]
		private int m_GenStartTime;

		// Token: 0x040094E0 RID: 38112
		[Token(Token = "0x40094E0")]
		[FieldOffset(Offset = "0x7C")]
		private int m_GenEndTime;
	}
}
