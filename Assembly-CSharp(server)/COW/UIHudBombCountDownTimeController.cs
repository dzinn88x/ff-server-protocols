using System;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200209C RID: 8348
	[Token(Token = "0x200209C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FDB5C", Offset = "0x10FDB5C")]
	internal class UIHudBombCountDownTimeController : UIBaseController
	{
		// Token: 0x0600BBB3 RID: 48051 RVA: 0x00035190 File Offset: 0x00033390
		[Token(Token = "0x600BBB3")]
		[Address(RVA = "0x18970F4", Offset = "0x18970F4", VA = "0x7BBC0970F4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600BBB4 RID: 48052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBB4")]
		[Address(RVA = "0x1897144", Offset = "0x1897144", VA = "0x7BBC097144", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600BBB5 RID: 48053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBB5")]
		[Address(RVA = "0x1897350", Offset = "0x1897350", VA = "0x7BBC097350", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600BBB6 RID: 48054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBB6")]
		[Address(RVA = "0x1897470", Offset = "0x1897470", VA = "0x7BBC097470")]
		private void OnBombSettingPhaseSync(params object[] data)
		{
		}

		// Token: 0x0600BBB7 RID: 48055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBB7")]
		[Address(RVA = "0x18974F4", Offset = "0x18974F4", VA = "0x7BBC0974F4")]
		private void OnBombPlantTimeSync(params object[] data)
		{
		}

		// Token: 0x0600BBB8 RID: 48056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBB8")]
		[Address(RVA = "0x1897594", Offset = "0x1897594", VA = "0x7BBC097594")]
		private void Update()
		{
		}

		// Token: 0x0600BBB9 RID: 48057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBB9")]
		[Address(RVA = "0x1897CFC", Offset = "0x1897CFC", VA = "0x7BBC097CFC")]
		public UIHudBombCountDownTimeController()
		{
		}

		// Token: 0x0400BC84 RID: 48260
		[Token(Token = "0x400BC84")]
		[FieldOffset(Offset = "0x58")]
		private UIHudBombCountDownTimeView m_View;

		// Token: 0x0400BC85 RID: 48261
		[Token(Token = "0x400BC85")]
		[FieldOffset(Offset = "0x60")]
		private uint m_BombExplodeTime;

		// Token: 0x0400BC86 RID: 48262
		[Token(Token = "0x400BC86")]
		[FieldOffset(Offset = "0x68")]
		private StringBuilder m_Timer;

		// Token: 0x0400BC87 RID: 48263
		[Token(Token = "0x400BC87")]
		[FieldOffset(Offset = "0x70")]
		private uint min;

		// Token: 0x0400BC88 RID: 48264
		[Token(Token = "0x400BC88")]
		[FieldOffset(Offset = "0x74")]
		private uint sec;

		// Token: 0x0400BC89 RID: 48265
		[Token(Token = "0x400BC89")]
		[FieldOffset(Offset = "0x78")]
		private bkHti^T bombGame;

		// Token: 0x0400BC8A RID: 48266
		[Token(Token = "0x400BC8A")]
		[FieldOffset(Offset = "0x0")]
		private static string ZoneAStr;

		// Token: 0x0400BC8B RID: 48267
		[Token(Token = "0x400BC8B")]
		[FieldOffset(Offset = "0x8")]
		private static string ZoneBStr;
	}
}
