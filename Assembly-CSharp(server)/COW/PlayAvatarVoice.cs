using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001347 RID: 4935
	[Token(Token = "0x2001347")]
	public class PlayAvatarVoice : IAvatarVoice
	{
		// Token: 0x06004E67 RID: 20071 RVA: 0x00017EC8 File Offset: 0x000160C8
		[Token(Token = "0x6004E67")]
		[Address(RVA = "0x20537D8", Offset = "0x20537D8", VA = "0x7BBC8537D8", Slot = "4")]
		public bool PlayAvatarVoiceShot(uint avatarID, AvatarVoice_Trigger_Type triggerType, string language = "", bool random = false, [Optional] Action audioEndCB)
		{
			return default(bool);
		}

		// Token: 0x06004E68 RID: 20072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E68")]
		[Address(RVA = "0x2053CBC", Offset = "0x2053CBC", VA = "0x7BBC853CBC")]
		private void PlayShot(ResourceID voiceID)
		{
		}

		// Token: 0x06004E69 RID: 20073 RVA: 0x00017EE0 File Offset: 0x000160E0
		[Token(Token = "0x6004E69")]
		[Address(RVA = "0x2053C64", Offset = "0x2053C64", VA = "0x7BBC853C64")]
		private bool CanPlayShot(uint avatarID)
		{
			return default(bool);
		}

		// Token: 0x06004E6A RID: 20074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E6A")]
		[Address(RVA = "0x2054074", Offset = "0x2054074", VA = "0x7BBC854074", Slot = "5")]
		public void StopAvatarVoiceShot()
		{
		}

		// Token: 0x06004E6B RID: 20075 RVA: 0x00017EF8 File Offset: 0x000160F8
		[Token(Token = "0x6004E6B")]
		[Address(RVA = "0x205420C", Offset = "0x205420C", VA = "0x7BBC85420C")]
		public float GetPlayingAudioClipLenth()
		{
			return 0f;
		}

		// Token: 0x06004E6C RID: 20076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E6C")]
		[Address(RVA = "0x2054194", Offset = "0x2054194", VA = "0x7BBC854194")]
		private void CancelDelayCall()
		{
		}

		// Token: 0x06004E6D RID: 20077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E6D")]
		[Address(RVA = "0x205430C", Offset = "0x205430C", VA = "0x7BBC85430C")]
		public PlayAvatarVoice()
		{
		}

		// Token: 0x06004E6E RID: 20078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E6E")]
		[Address(RVA = "0x2054314", Offset = "0x2054314", VA = "0x7BBC854314")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DE88", Offset = "0x113DE88")]
		private void <PlayShot>b__6_0()
		{
		}

		// Token: 0x04007571 RID: 30065
		[Token(Token = "0x4007571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private uint m_LastAvatarId;

		// Token: 0x04007572 RID: 30066
		[Token(Token = "0x4007572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private ResourceID m_LastVoiceId;

		// Token: 0x04007573 RID: 30067
		[Token(Token = "0x4007573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AudioResource m_AudioResource;

		// Token: 0x04007574 RID: 30068
		[Token(Token = "0x4007574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private uint m_DelayCall;

		// Token: 0x04007575 RID: 30069
		[Token(Token = "0x4007575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Action m_AudioEndCB;

		// Token: 0x02001348 RID: 4936
		[Token(Token = "0x2001348")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB188", Offset = "0x10EB188")]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06004E6F RID: 20079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E6F")]
			[Address(RVA = "0x2053C5C", Offset = "0x2053C5C", VA = "0x7BBC853C5C")]
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x06004E70 RID: 20080 RVA: 0x00017F10 File Offset: 0x00016110
			[Token(Token = "0x6004E70")]
			[Address(RVA = "0x20543F8", Offset = "0x20543F8", VA = "0x7BBC8543F8")]
			internal bool <PlayAvatarVoiceShot>b__0(AssistantAudioData a)
			{
				return default(bool);
			}

			// Token: 0x04007576 RID: 30070
			[Token(Token = "0x4007576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AvatarVoice_Trigger_Type triggerType;
		}
	}
}
