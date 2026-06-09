using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200125E RID: 4702
	[Token(Token = "0x200125E")]
	internal class AudioConfigDataManager : SingletonModule<AudioConfigDataManager>
	{
		// Token: 0x060048D2 RID: 18642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048D2")]
		[Address(RVA = "0x1552B38", Offset = "0x1552B38", VA = "0x7BBBD52B38", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x060048D3 RID: 18643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048D3")]
		[Address(RVA = "0x1552BBC", Offset = "0x1552BBC", VA = "0x7BBBD52BBC", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x060048D4 RID: 18644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D4")]
		[Address(RVA = "0x15535B8", Offset = "0x15535B8", VA = "0x7BBBD535B8")]
		public List<AssistantAudioData> GetAssistantAudioDataByAvatarID(uint avatarID)
		{
			return null;
		}

		// Token: 0x060048D5 RID: 18645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D5")]
		[Address(RVA = "0x1553640", Offset = "0x1553640", VA = "0x7BBBD53640")]
		public List<AssistantAudioData> GetAssistantAudioDataByAvatarIDAndLanguage(uint avatarID, string laguage, bool needCheck = false)
		{
			return null;
		}

		// Token: 0x060048D6 RID: 18646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048D6")]
		[Address(RVA = "0x15538DC", Offset = "0x15538DC", VA = "0x7BBBD538DC")]
		public AudioConfigDataManager()
		{
		}

		// Token: 0x040071C3 RID: 29123
		[Token(Token = "0x40071C3")]
		public const string DEFAULT_INGAME_CONFIGNAME = "default_ingame";

		// Token: 0x040071C4 RID: 29124
		[Token(Token = "0x40071C4")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, List<AssistantAudioData>> m_AssistAudioConfigMap;

		// Token: 0x040071C5 RID: 29125
		[Token(Token = "0x40071C5")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<uint, Dictionary<string, List<AssistantAudioData>>> m_multiLanguageAssistAudioConfigMap;
	}
}
