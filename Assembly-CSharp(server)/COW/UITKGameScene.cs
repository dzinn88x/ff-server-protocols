using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200208F RID: 8335
	[Token(Token = "0x200208F")]
	internal class UITKGameScene : UIInGameScene
	{
		// Token: 0x0600BB16 RID: 47894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB16")]
		[Address(RVA = "0x1F50348", Offset = "0x1F50348", VA = "0x7BBC750348", Slot = "12")]
		protected override void OpenCommonHud()
		{
		}

		// Token: 0x0600BB17 RID: 47895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB17")]
		[Address(RVA = "0x1F50484", Offset = "0x1F50484", VA = "0x7BBC750484", Slot = "25")]
		protected override void OnOpenHudInPregame()
		{
		}

		// Token: 0x0600BB18 RID: 47896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB18")]
		[Address(RVA = "0x1F506BC", Offset = "0x1F506BC", VA = "0x7BBC7506BC", Slot = "27")]
		protected override void OnOpenHudBeginFight()
		{
		}

		// Token: 0x0600BB19 RID: 47897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BB19")]
		[Address(RVA = "0x1F50724", Offset = "0x1F50724", VA = "0x7BBC750724", Slot = "14")]
		protected override Type GetMatchResultType()
		{
			return null;
		}

		// Token: 0x0600BB1A RID: 47898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB1A")]
		[Address(RVA = "0x1F50794", Offset = "0x1F50794", VA = "0x7BBC750794")]
		public UITKGameScene()
		{
		}

		// Token: 0x0600BB1B RID: 47899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB1B")]
		[Address(RVA = "0x1F507FC", Offset = "0x1F507FC", VA = "0x7BBC7507FC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147CC4", Offset = "0x1147CC4")]
		private void <OnOpenHudInPregame>b__3_0()
		{
		}

		// Token: 0x0400BC39 RID: 48185
		[Token(Token = "0x400BC39")]
		[FieldOffset(Offset = "0x3D0")]
		private UIHudTKScoreInfoController m_UIHudTKScoreInfoController;

		// Token: 0x0400BC3A RID: 48186
		[Token(Token = "0x400BC3A")]
		[FieldOffset(Offset = "0x3D8")]
		private UIHudTKProgressBarController m_UIHudTKProgressBarController;
	}
}
