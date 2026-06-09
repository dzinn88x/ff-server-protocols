using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x020001D5 RID: 469
[Token(Token = "0x20001D5")]
public interface IStreamerFunc
{
	// Token: 0x060009A7 RID: 2471
	[Token(Token = "0x60009A7")]
	Transform GetTargetPlayer();

	// Token: 0x060009A8 RID: 2472
	[Token(Token = "0x60009A8")]
	AsyncOperation LoadSceneAsync(string sourcePath, LoadSceneMode mode);

	// Token: 0x060009A9 RID: 2473
	[Token(Token = "0x60009A9")]
	AssetBundle GetStreamSceneAB();

	// Token: 0x060009AA RID: 2474
	[Token(Token = "0x60009AA")]
	byte[] GetStreamSceneABTexRefInfo();

	// Token: 0x060009AB RID: 2475
	[Token(Token = "0x60009AB")]
	void OnLoadSceneFinish(string sourcePath, bool result);

	// Token: 0x060009AC RID: 2476
	[Token(Token = "0x60009AC")]
	void RepeatAction(float interval, Action action);

	// Token: 0x060009AD RID: 2477
	[Token(Token = "0x60009AD")]
	void NotifySceneEvent(StreamerType type, string name, bool loaded);
}
