using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200125D RID: 4701
	[Token(Token = "0x200125D")]
	internal class FFAudioImpl : IAudioInterface
	{
		// Token: 0x060048CE RID: 18638 RVA: 0x00016170 File Offset: 0x00014370
		[Token(Token = "0x60048CE")]
		[Address(RVA = "0x1B95080", Offset = "0x1B95080", VA = "0x7BBC395080", Slot = "4")]
		public ResourceID GetTwoDAudioSourceResID()
		{
			return default(ResourceID);
		}

		// Token: 0x060048CF RID: 18639 RVA: 0x00016188 File Offset: 0x00014388
		[Token(Token = "0x60048CF")]
		[Address(RVA = "0x1B950D0", Offset = "0x1B950D0", VA = "0x7BBC3950D0", Slot = "5")]
		public float GetDistanceToListener(Vector3 sound_pos)
		{
			return 0f;
		}

		// Token: 0x060048D0 RID: 18640 RVA: 0x000161A0 File Offset: 0x000143A0
		[Token(Token = "0x60048D0")]
		[Address(RVA = "0x1B95278", Offset = "0x1B95278", VA = "0x7BBC395278", Slot = "6")]
		public int GetOneShotLimitInOneFrame()
		{
			return 0;
		}

		// Token: 0x060048D1 RID: 18641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048D1")]
		[Address(RVA = "0x1B952E0", Offset = "0x1B952E0", VA = "0x7BBC3952E0")]
		public FFAudioImpl()
		{
		}
	}
}
