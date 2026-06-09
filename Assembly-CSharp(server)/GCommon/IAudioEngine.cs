using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EB7 RID: 3767
	[Token(Token = "0x2000EB7")]
	public interface IAudioEngine
	{
		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06003393 RID: 13203
		[Token(Token = "0x1700067A")]
		bool MusicOn { [Token(Token = "0x6003393")] get; }

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06003394 RID: 13204
		[Token(Token = "0x1700067B")]
		bool SoundEffectOn { [Token(Token = "0x6003394")] get; }

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06003395 RID: 13205
		[Token(Token = "0x1700067C")]
		float MusicVolume { [Token(Token = "0x6003395")] get; }

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06003396 RID: 13206
		[Token(Token = "0x1700067D")]
		float SoundEffectVolume { [Token(Token = "0x6003396")] get; }

		// Token: 0x06003397 RID: 13207
		[Token(Token = "0x6003397")]
		void Init(GameObject owned_object);

		// Token: 0x06003398 RID: 13208
		[Token(Token = "0x6003398")]
		void RunOneFrame(float gameTime, float deltaTime);

		// Token: 0x06003399 RID: 13209
		[Token(Token = "0x6003399")]
		void SetMusicOn(bool v);

		// Token: 0x0600339A RID: 13210
		[Token(Token = "0x600339A")]
		void SetMusicVolume(float v);

		// Token: 0x0600339B RID: 13211
		[Token(Token = "0x600339B")]
		void SetSoundEffectVolume(float v);

		// Token: 0x0600339C RID: 13212
		[Token(Token = "0x600339C")]
		void SetSoundEffectOn(bool v);

		// Token: 0x0600339D RID: 13213
		[Token(Token = "0x600339D")]
		void OnSettingChanged();

		// Token: 0x0600339E RID: 13214
		[Token(Token = "0x600339E")]
		void OnGameDestory();

		// Token: 0x0600339F RID: 13215
		[Token(Token = "0x600339F")]
		void Play3DShot(ResourceID sound, Vector3 worldPos, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default);

		// Token: 0x060033A0 RID: 13216
		[Token(Token = "0x60033A0")]
		void Play3DShot(ResourceID sound, Transform parent, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default);

		// Token: 0x060033A1 RID: 13217
		[Token(Token = "0x60033A1")]
		AudioResource Play2DLoopStart(ResourceID sound, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default);

		// Token: 0x060033A2 RID: 13218
		[Token(Token = "0x60033A2")]
		void Play2DLoopStop(AudioResource audioSourceObj, bool fade, bool isNeedUnloadAudioData = false, float volumnChangeSpeed = 1f);

		// Token: 0x060033A3 RID: 13219
		[Token(Token = "0x60033A3")]
		GameObject Play3DLoopStart(ResourceID sound, Transform parent, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default);

		// Token: 0x060033A4 RID: 13220
		[Token(Token = "0x60033A4")]
		void Play3DLoopStop(GameObject audioSourceObj);

		// Token: 0x060033A5 RID: 13221
		[Token(Token = "0x60033A5")]
		GameObject PlayOneShot(ResourceID sound, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default);

		// Token: 0x060033A6 RID: 13222
		[Token(Token = "0x60033A6")]
		AudioResWithCallBackBase PlayOneShotWithCallBack(ResourceID sound, AudioEndInternalCallBack callBack, float volume = 1f);

		// Token: 0x060033A7 RID: 13223
		[Token(Token = "0x60033A7")]
		void StopPlayShot();

		// Token: 0x060033A8 RID: 13224
		[Token(Token = "0x60033A8")]
		void StopPlayShot(GameObject obj);

		// Token: 0x060033A9 RID: 13225
		[Token(Token = "0x60033A9")]
		void PlayMusic(ResourceID sound, bool fadeIn = true, bool fadeOutCurrent = true, bool loop = true, bool isNeedUnloadAudioData = false, bool needContinuePlay = false);

		// Token: 0x060033AA RID: 13226
		[Token(Token = "0x60033AA")]
		void StopOneShotWithCallBack(AudioResWithCallBackBase resource);

		// Token: 0x060033AB RID: 13227
		[Token(Token = "0x60033AB")]
		bool IsCurMusicPlayThisID(ResourceID AudioID);

		// Token: 0x060033AC RID: 13228
		[Token(Token = "0x60033AC")]
		void StopMusic(bool fadeOutCurrent = true, float volumnChangeSpeed = 1f);

		// Token: 0x060033AD RID: 13229
		[Token(Token = "0x60033AD")]
		void PlayCurrentMusicFadeEffect(float targetvolume);

		// Token: 0x060033AE RID: 13230
		[Token(Token = "0x60033AE")]
		void CancelCurrentMusicFadeEffect();
	}
}
