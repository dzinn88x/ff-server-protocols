using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001349 RID: 4937
	[Token(Token = "0x2001349")]
	public class PlayAvatarVoiceWithChannel : IAvatarVoice
	{
		// Token: 0x06004E71 RID: 20081 RVA: 0x00017F28 File Offset: 0x00016128
		[Token(Token = "0x6004E71")]
		[Address(RVA = "0x2054434", Offset = "0x2054434", VA = "0x7BBC854434", Slot = "4")]
		public bool PlayAvatarVoiceShot(uint avatarID, AvatarVoice_Trigger_Type triggerType, string language = "", bool random = false, [Optional] Action audioEndCB)
		{
			return default(bool);
		}

		// Token: 0x06004E72 RID: 20082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E72")]
		[Address(RVA = "0x2054960", Offset = "0x2054960", VA = "0x7BBC854960")]
		private void PlayShot(ResourceID voiceID)
		{
		}

		// Token: 0x06004E73 RID: 20083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E73")]
		[Address(RVA = "0x2054BE4", Offset = "0x2054BE4", VA = "0x7BBC854BE4")]
		private void AudioEndCallBack(bool end_by_cancle, ResourceID res_id)
		{
		}

		// Token: 0x06004E74 RID: 20084 RVA: 0x00017F40 File Offset: 0x00016140
		[Token(Token = "0x6004E74")]
		[Address(RVA = "0x20548B0", Offset = "0x20548B0", VA = "0x7BBC8548B0")]
		private bool CanPlayShot(uint avatarID)
		{
			return default(bool);
		}

		// Token: 0x06004E75 RID: 20085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E75")]
		[Address(RVA = "0x2054AEC", Offset = "0x2054AEC", VA = "0x7BBC854AEC", Slot = "5")]
		public void StopAvatarVoiceShot()
		{
		}

		// Token: 0x06004E76 RID: 20086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E76")]
		[Address(RVA = "0x2054CC8", Offset = "0x2054CC8", VA = "0x7BBC854CC8")]
		public PlayAvatarVoiceWithChannel()
		{
		}

		// Token: 0x04007577 RID: 30071
		[Token(Token = "0x4007577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private uint m_LastAvatarId;

		// Token: 0x04007578 RID: 30072
		[Token(Token = "0x4007578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private EAudioChannel m_AudioChannel;

		// Token: 0x04007579 RID: 30073
		[Token(Token = "0x4007579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Action m_AudioEndCB;

		// Token: 0x0200134A RID: 4938
		[Token(Token = "0x200134A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB198", Offset = "0x10EB198")]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06004E77 RID: 20087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E77")]
			[Address(RVA = "0x1EFDDB0", Offset = "0x1EFDDB0", VA = "0x7BBC6FDDB0")]
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x06004E78 RID: 20088 RVA: 0x00017F58 File Offset: 0x00016158
			[Token(Token = "0x6004E78")]
			[Address(RVA = "0x1EFDDB8", Offset = "0x1EFDDB8", VA = "0x7BBC6FDDB8")]
			internal bool <PlayAvatarVoiceShot>b__0(AssistantAudioData a)
			{
				return default(bool);
			}

			// Token: 0x0400757A RID: 30074
			[Token(Token = "0x400757A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AvatarVoice_Trigger_Type triggerType;
		}
	}
}
