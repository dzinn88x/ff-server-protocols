using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001DD RID: 477
[Token(Token = "0x20001DD")]
public interface IAudioInterface
{
	// Token: 0x060009D3 RID: 2515
	[Token(Token = "0x60009D3")]
	ResourceID GetTwoDAudioSourceResID();

	// Token: 0x060009D4 RID: 2516
	[Token(Token = "0x60009D4")]
	float GetDistanceToListener(Vector3 sound_pos);

	// Token: 0x060009D5 RID: 2517
	[Token(Token = "0x60009D5")]
	int GetOneShotLimitInOneFrame();
}
