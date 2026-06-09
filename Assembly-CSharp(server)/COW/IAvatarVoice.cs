using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001344 RID: 4932
	[Token(Token = "0x2001344")]
	internal interface IAvatarVoice
	{
		// Token: 0x06004E5F RID: 20063
		[Token(Token = "0x6004E5F")]
		bool PlayAvatarVoiceShot(uint avatarID, AvatarVoice_Trigger_Type triggerType, string language = "", bool random = false, [Optional] Action audioEndCB);

		// Token: 0x06004E60 RID: 20064
		[Token(Token = "0x6004E60")]
		void StopAvatarVoiceShot();
	}
}
