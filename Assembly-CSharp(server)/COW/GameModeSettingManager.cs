using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020011BA RID: 4538
	[Token(Token = "0x20011BA")]
	internal class GameModeSettingManager : SingletonModule<GameModeSettingManager>
	{
		// Token: 0x0600468E RID: 18062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600468E")]
		[Address(RVA = "0x187EF98", Offset = "0x187EF98", VA = "0x7BBC07EF98", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600468F RID: 18063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600468F")]
		[Address(RVA = "0x187F1B0", Offset = "0x187F1B0", VA = "0x7BBC07F1B0", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06004690 RID: 18064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004690")]
		[Address(RVA = "0x187F1B4", Offset = "0x187F1B4", VA = "0x7BBC07F1B4")]
		public GameModeSetting GetModeSetting(uint map_id, uint mode_id, bool isWaitingRoom)
		{
			return null;
		}

		// Token: 0x06004691 RID: 18065 RVA: 0x00015420 File Offset: 0x00013620
		[Token(Token = "0x6004691")]
		[Address(RVA = "0x187F460", Offset = "0x187F460", VA = "0x7BBC07F460")]
		private ulong GetModeSettingKey(uint map_id, uint mode_id, bool isWaitingRoom)
		{
			return 0UL;
		}

		// Token: 0x06004692 RID: 18066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004692")]
		[Address(RVA = "0x187F03C", Offset = "0x187F03C", VA = "0x7BBC07F03C")]
		private GameModeSetting LoadModeSetting(ResourceID resID, [Optional] GameModeSetting defaultSetting)
		{
			return null;
		}

		// Token: 0x06004693 RID: 18067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004693")]
		[Address(RVA = "0x187F49C", Offset = "0x187F49C", VA = "0x7BBC07F49C")]
		public GameModeSettingManager()
		{
		}

		// Token: 0x04005D7A RID: 23930
		[Token(Token = "0x4005D7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameModeSetting m_DefaultGameSetting;

		// Token: 0x04005D7B RID: 23931
		[Token(Token = "0x4005D7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<ulong, GameModeSetting> m_GameModeSettings;
	}
}
