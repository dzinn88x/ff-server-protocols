using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001346 RID: 4934
	[Token(Token = "0x2001346")]
	public class AvatarVoiceManager : SingletonModule<AvatarVoiceManager>
	{
		// Token: 0x06004E61 RID: 20065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E61")]
		[Address(RVA = "0x21C2D20", Offset = "0x21C2D20", VA = "0x7BBC9C2D20", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06004E62 RID: 20066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E62")]
		[Address(RVA = "0x21C2D80", Offset = "0x21C2D80", VA = "0x7BBC9C2D80", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06004E63 RID: 20067 RVA: 0x00017E98 File Offset: 0x00016098
		[Token(Token = "0x6004E63")]
		[Address(RVA = "0x21C2E40", Offset = "0x21C2E40", VA = "0x7BBC9C2E40")]
		public bool PlayAvatarVoiceShot(uint avatarID, AvatarVoice_Trigger_Type triggerType, string language = "", bool random = false, [Optional] Action audioEndCB)
		{
			return default(bool);
		}

		// Token: 0x06004E64 RID: 20068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E64")]
		[Address(RVA = "0x21C2D84", Offset = "0x21C2D84", VA = "0x7BBC9C2D84")]
		public void StopAvatarVoiceShot()
		{
		}

		// Token: 0x06004E65 RID: 20069 RVA: 0x00017EB0 File Offset: 0x000160B0
		[Token(Token = "0x6004E65")]
		[Address(RVA = "0x21C2F48", Offset = "0x21C2F48", VA = "0x7BBC9C2F48")]
		public bool AudioABIsReady(ResourceID resourceID)
		{
			return default(bool);
		}

		// Token: 0x06004E66 RID: 20070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E66")]
		[Address(RVA = "0x21C2FDC", Offset = "0x21C2FDC", VA = "0x7BBC9C2FDC")]
		public AvatarVoiceManager()
		{
		}

		// Token: 0x04007570 RID: 30064
		[Token(Token = "0x4007570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IAvatarVoice m_AvatarVoice;
	}
}
