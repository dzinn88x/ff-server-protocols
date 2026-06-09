using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001621 RID: 5665
	[Token(Token = "0x2001621")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EFBC4", Offset = "0x10EFBC4")]
	internal class UIHudPVEBossInfoController : UIBaseController
	{
		// Token: 0x060065D3 RID: 26067 RVA: 0x0001D160 File Offset: 0x0001B360
		[Token(Token = "0x60065D3")]
		[Address(RVA = "0x17C036C", Offset = "0x17C036C", VA = "0x7BBBFC036C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060065D4 RID: 26068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D4")]
		[Address(RVA = "0x17C03BC", Offset = "0x17C03BC", VA = "0x7BBBFC03BC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060065D5 RID: 26069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D5")]
		[Address(RVA = "0x17C04FC", Offset = "0x17C04FC", VA = "0x7BBBFC04FC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060065D6 RID: 26070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D6")]
		[Address(RVA = "0x17C0624", Offset = "0x17C0624", VA = "0x7BBBFC0624")]
		private void OnInWarningRegion(object[] data)
		{
		}

		// Token: 0x060065D7 RID: 26071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D7")]
		[Address(RVA = "0x17C0700", Offset = "0x17C0700", VA = "0x7BBBFC0700")]
		private void OnNewRoundStart(object[] data)
		{
		}

		// Token: 0x060065D8 RID: 26072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D8")]
		[Address(RVA = "0x17C09E4", Offset = "0x17C09E4", VA = "0x7BBBFC09E4")]
		private void OnBossSpawn(object[] data)
		{
		}

		// Token: 0x060065D9 RID: 26073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D9")]
		[Address(RVA = "0x17C0888", Offset = "0x17C0888", VA = "0x7BBBFC0888")]
		private void ShowWarningText(float delayTime, string text_content)
		{
		}

		// Token: 0x060065DA RID: 26074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065DA")]
		[Address(RVA = "0x17C0B7C", Offset = "0x17C0B7C", VA = "0x7BBBFC0B7C")]
		private void OnBossDead(object[] data)
		{
		}

		// Token: 0x060065DB RID: 26075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065DB")]
		[Address(RVA = "0x17C0BC0", Offset = "0x17C0BC0", VA = "0x7BBBFC0BC0")]
		public UIHudPVEBossInfoController()
		{
		}

		// Token: 0x060065DC RID: 26076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065DC")]
		[Address(RVA = "0x17C0BC8", Offset = "0x17C0BC8", VA = "0x7BBBFC0BC8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114052C", Offset = "0x114052C")]
		private void <ShowWarningText>b__9_0()
		{
		}

		// Token: 0x040083E4 RID: 33764
		[Token(Token = "0x40083E4")]
		private const byte MAX_TURN_COUNT = 4;

		// Token: 0x040083E5 RID: 33765
		[Token(Token = "0x40083E5")]
		[FieldOffset(Offset = "0x58")]
		private UIHudPVEBossInfoView m_View;

		// Token: 0x040083E6 RID: 33766
		[Token(Token = "0x40083E6")]
		[FieldOffset(Offset = "0x60")]
		private uint m_delcayCall;
	}
}
