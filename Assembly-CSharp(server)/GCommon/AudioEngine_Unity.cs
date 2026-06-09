using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EB8 RID: 3768
	[Token(Token = "0x2000EB8")]
	public class AudioEngine_Unity : IAudioEngine, IReusableObjectOwner
	{
		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x060033AF RID: 13231 RVA: 0x0000F858 File Offset: 0x0000DA58
		// (set) Token: 0x060033B0 RID: 13232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067E")]
		public bool MusicOn
		{
			[Token(Token = "0x60033AF")]
			[Address(RVA = "0x25DBBB8", Offset = "0x25DBBB8", VA = "0x7BBCDDBBB8", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B2C4", Offset = "0x113B2C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60033B0")]
			[Address(RVA = "0x25DBBC0", Offset = "0x25DBBC0", VA = "0x7BBCDDBBC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B2D4", Offset = "0x113B2D4")]
			private set
			{
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x060033B1 RID: 13233 RVA: 0x0000F870 File Offset: 0x0000DA70
		// (set) Token: 0x060033B2 RID: 13234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067F")]
		public bool SoundEffectOn
		{
			[Token(Token = "0x60033B1")]
			[Address(RVA = "0x25DBBCC", Offset = "0x25DBBCC", VA = "0x7BBCDDBBCC", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B2E4", Offset = "0x113B2E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60033B2")]
			[Address(RVA = "0x25DBBD4", Offset = "0x25DBBD4", VA = "0x7BBCDDBBD4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B2F4", Offset = "0x113B2F4")]
			private set
			{
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x060033B3 RID: 13235 RVA: 0x0000F888 File Offset: 0x0000DA88
		// (set) Token: 0x060033B4 RID: 13236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000680")]
		public float MusicVolume
		{
			[Token(Token = "0x60033B3")]
			[Address(RVA = "0x25DBBE0", Offset = "0x25DBBE0", VA = "0x7BBCDDBBE0", Slot = "6")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B304", Offset = "0x113B304")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60033B4")]
			[Address(RVA = "0x25DBBE8", Offset = "0x25DBBE8", VA = "0x7BBCDDBBE8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B314", Offset = "0x113B314")]
			private set
			{
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x060033B5 RID: 13237 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
		// (set) Token: 0x060033B6 RID: 13238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000681")]
		public float SoundEffectVolume
		{
			[Token(Token = "0x60033B5")]
			[Address(RVA = "0x25DBBF0", Offset = "0x25DBBF0", VA = "0x7BBCDDBBF0", Slot = "7")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B324", Offset = "0x113B324")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60033B6")]
			[Address(RVA = "0x25DBBF8", Offset = "0x25DBBF8", VA = "0x7BBCDDBBF8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B334", Offset = "0x113B334")]
			private set
			{
			}
		}

		// Token: 0x060033B7 RID: 13239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033B7")]
		[Address(RVA = "0x25DBC00", Offset = "0x25DBC00", VA = "0x7BBCDDBC00", Slot = "8")]
		public void Init(GameObject owned_object)
		{
		}

		// Token: 0x060033B8 RID: 13240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033B8")]
		[Address(RVA = "0x25DBD50", Offset = "0x25DBD50", VA = "0x7BBCDDBD50", Slot = "31")]
		public void CancelCurrentMusicFadeEffect()
		{
		}

		// Token: 0x060033B9 RID: 13241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033B9")]
		[Address(RVA = "0x25DBE18", Offset = "0x25DBE18", VA = "0x7BBCDDBE18")]
		public void ClearAudioGroupMap()
		{
		}

		// Token: 0x060033BA RID: 13242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033BA")]
		[Address(RVA = "0x25DC150", Offset = "0x25DC150", VA = "0x7BBCDDC150")]
		public void InitAudioGroupInfo(uint group_id, int limit_count, int max_range = 25)
		{
		}

		// Token: 0x060033BB RID: 13243 RVA: 0x0000F8B8 File Offset: 0x0000DAB8
		[Token(Token = "0x60033BB")]
		[Address(RVA = "0x25DC2CC", Offset = "0x25DC2CC", VA = "0x7BBCDDC2CC", Slot = "28")]
		public bool IsCurMusicPlayThisID(ResourceID AudioID)
		{
			return default(bool);
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033BC")]
		[Address(RVA = "0x25DC364", Offset = "0x25DC364", VA = "0x7BBCDDC364")]
		public AudioClip LoadAudioClip(ResourceID sound)
		{
			return null;
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033BD")]
		[Address(RVA = "0x25DC468", Offset = "0x25DC468", VA = "0x7BBCDDC468", Slot = "15")]
		public void OnGameDestory()
		{
		}

		// Token: 0x060033BE RID: 13246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033BE")]
		[Address(RVA = "0x25DC4D0", Offset = "0x25DC4D0", VA = "0x7BBCDDC4D0")]
		private void StopAll2DLoopSound()
		{
		}

		// Token: 0x060033BF RID: 13247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033BF")]
		[Address(RVA = "0x25DC6E8", Offset = "0x25DC6E8", VA = "0x7BBCDDC6E8", Slot = "32")]
		public void OnReusableObjectRecycled(ResourceID rID, GameObject obj)
		{
		}

		// Token: 0x060033C0 RID: 13248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C0")]
		[Address(RVA = "0x25DC7BC", Offset = "0x25DC7BC", VA = "0x7BBCDDC7BC", Slot = "14")]
		public void OnSettingChanged()
		{
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C1")]
		[Address(RVA = "0x25DC958", Offset = "0x25DC958", VA = "0x7BBCDDC958", Slot = "18")]
		public AudioResource Play2DLoopStart(ResourceID sound, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default)
		{
			return null;
		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C2")]
		[Address(RVA = "0x25DCC40", Offset = "0x25DCC40", VA = "0x7BBCDDCC40", Slot = "21")]
		public void Play3DLoopStop(GameObject audioSourceObj)
		{
		}

		// Token: 0x060033C3 RID: 13251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C3")]
		[Address(RVA = "0x25DCD60", Offset = "0x25DCD60", VA = "0x7BBCDDCD60", Slot = "16")]
		public void Play3DShot(ResourceID sound, Vector3 worldPos, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default)
		{
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C4")]
		[Address(RVA = "0x25DD2EC", Offset = "0x25DD2EC", VA = "0x7BBCDDD2EC", Slot = "17")]
		public void Play3DShot(ResourceID sound, Transform parent, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default)
		{
		}

		// Token: 0x060033C5 RID: 13253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C5")]
		[Address(RVA = "0x25DCD70", Offset = "0x25DCD70", VA = "0x7BBCDDCD70")]
		private void Play3DShotWithTransOrPos(ResourceID sound, Transform parent, Vector3 worldPos, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default)
		{
		}

		// Token: 0x060033C6 RID: 13254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C6")]
		[Address(RVA = "0x25DD3DC", Offset = "0x25DD3DC", VA = "0x7BBCDDD3DC")]
		public void Play3DShotWithGroup(uint group_id, ResourceID sound, Vector3 worldPos, Vector3 listenerPos, ResourceID audioSourceID, float volume = 1f)
		{
		}

		// Token: 0x060033C7 RID: 13255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C7")]
		[Address(RVA = "0x25DDC7C", Offset = "0x25DDC7C", VA = "0x7BBCDDDC7C", Slot = "30")]
		public void PlayCurrentMusicFadeEffect(float targetvolume)
		{
		}

		// Token: 0x060033C8 RID: 13256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C8")]
		[Address(RVA = "0x25DDDE4", Offset = "0x25DDDE4", VA = "0x7BBCDDDDE4", Slot = "26")]
		public void PlayMusic(ResourceID sound, bool fadeIn = true, bool fadeOutCurrent = true, bool loop = true, bool isNeedUnloadAudioData = false, bool needContinuePlay = false)
		{
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C9")]
		[Address(RVA = "0x25DCAA4", Offset = "0x25DCAA4", VA = "0x7BBCDDCAA4")]
		private AudioResource AllocaAndLoadAudioResourceClip(ResourceID sound, bool loop)
		{
			return null;
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033CA")]
		[Address(RVA = "0x25DE328", Offset = "0x25DE328", VA = "0x7BBCDDE328")]
		private AudioResWithCallBackDefault AllocaAndLoadAudioResourceClip(ResourceID sound, bool loop, AudioEndInternalCallBack callBack)
		{
			return null;
		}

		// Token: 0x060033CB RID: 13259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033CB")]
		[Address(RVA = "0x25DE4D4", Offset = "0x25DE4D4", VA = "0x7BBCDDE4D4", Slot = "23")]
		public AudioResWithCallBackBase PlayOneShotWithCallBack(ResourceID sound, AudioEndInternalCallBack callBack, float volume = 1f)
		{
			return null;
		}

		// Token: 0x060033CC RID: 13260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033CC")]
		[Address(RVA = "0x25DE6E4", Offset = "0x25DE6E4", VA = "0x7BBCDDE6E4", Slot = "27")]
		public void StopOneShotWithCallBack(AudioResWithCallBackBase resource)
		{
		}

		// Token: 0x060033CD RID: 13261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033CD")]
		[Address(RVA = "0x25DE814", Offset = "0x25DE814", VA = "0x7BBCDDE814", Slot = "22")]
		public GameObject PlayOneShot(ResourceID sound, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default)
		{
			return null;
		}

		// Token: 0x060033CE RID: 13262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033CE")]
		[Address(RVA = "0x25DEC38", Offset = "0x25DEC38", VA = "0x7BBCDDEC38", Slot = "9")]
		public void RunOneFrame(float gameTime, float deltaTime)
		{
		}

		// Token: 0x060033CF RID: 13263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033CF")]
		[Address(RVA = "0x25DFAFC", Offset = "0x25DFAFC", VA = "0x7BBCDDFAFC", Slot = "10")]
		public void SetMusicOn(bool v)
		{
		}

		// Token: 0x060033D0 RID: 13264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D0")]
		[Address(RVA = "0x25DFE1C", Offset = "0x25DFE1C", VA = "0x7BBCDDFE1C", Slot = "11")]
		public void SetMusicVolume(float v)
		{
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D1")]
		[Address(RVA = "0x25DFE78", Offset = "0x25DFE78", VA = "0x7BBCDDFE78", Slot = "13")]
		public void SetSoundEffectOn(bool v)
		{
		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D2")]
		[Address(RVA = "0x25DFC08", Offset = "0x25DFC08", VA = "0x7BBCDDFC08")]
		public void StopAndClearFadeEffect()
		{
		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D3")]
		[Address(RVA = "0x25DE148", Offset = "0x25DE148", VA = "0x7BBCDDE148", Slot = "29")]
		public void StopMusic(bool fadeOutCurrent = true, float volChangeSpeed = 1f)
		{
		}

		// Token: 0x060033D4 RID: 13268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D4")]
		[Address(RVA = "0x25DFE98", Offset = "0x25DFE98", VA = "0x7BBCDDFE98", Slot = "24")]
		public void StopPlayShot()
		{
		}

		// Token: 0x060033D5 RID: 13269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D5")]
		[Address(RVA = "0x25E00C4", Offset = "0x25E00C4", VA = "0x7BBCDE00C4", Slot = "25")]
		public void StopPlayShot(GameObject go)
		{
		}

		// Token: 0x060033D6 RID: 13270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D6")]
		[Address(RVA = "0x25E02B0", Offset = "0x25E02B0", VA = "0x7BBCDE02B0", Slot = "12")]
		public void SetSoundEffectVolume(float v)
		{
		}

		// Token: 0x060033D7 RID: 13271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D7")]
		[Address(RVA = "0x25E02CC", Offset = "0x25E02CC", VA = "0x7BBCDE02CC", Slot = "19")]
		public void Play2DLoopStop(AudioResource audioSourceObj, bool fade, bool isNeedUnloadAudioData = false, float volumnChangeSpeed = 1f)
		{
		}

		// Token: 0x060033D8 RID: 13272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D8")]
		[Address(RVA = "0x25E0508", Offset = "0x25E0508", VA = "0x7BBCDE0508", Slot = "20")]
		public GameObject Play3DLoopStart(ResourceID sound, Transform parent, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default)
		{
			return null;
		}

		// Token: 0x060033D9 RID: 13273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D9")]
		[Address(RVA = "0x25E0848", Offset = "0x25E0848", VA = "0x7BBCDE0848")]
		public void RestoreLoopAudio()
		{
		}

		// Token: 0x060033DA RID: 13274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033DA")]
		[Address(RVA = "0x25E0900", Offset = "0x25E0900", VA = "0x7BBCDE0900")]
		public AudioEngine_Unity()
		{
		}

		// Token: 0x040047BE RID: 18366
		[Token(Token = "0x40047BE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E7A8", Offset = "0x112E7A8")]
		private bool <MusicOn>k__BackingField;

		// Token: 0x040047BF RID: 18367
		[Token(Token = "0x40047BF")]
		[FieldOffset(Offset = "0x11")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E7B8", Offset = "0x112E7B8")]
		private bool <SoundEffectOn>k__BackingField;

		// Token: 0x040047C0 RID: 18368
		[Token(Token = "0x40047C0")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E7C8", Offset = "0x112E7C8")]
		private float <MusicVolume>k__BackingField;

		// Token: 0x040047C1 RID: 18369
		[Token(Token = "0x40047C1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E7D8", Offset = "0x112E7D8")]
		private float <SoundEffectVolume>k__BackingField;

		// Token: 0x040047C2 RID: 18370
		[Token(Token = "0x40047C2")]
		[FieldOffset(Offset = "0x20")]
		private AudioResource m_CurrectMusic;

		// Token: 0x040047C3 RID: 18371
		[Token(Token = "0x40047C3")]
		[FieldOffset(Offset = "0x28")]
		private ObjectPool<AudioResource> m_AudioResourcePool;

		// Token: 0x040047C4 RID: 18372
		[Token(Token = "0x40047C4")]
		[FieldOffset(Offset = "0x30")]
		private ObjectPool<AudioResWithCallBackDefault> m_AudioResourceWithCallBackPool;

		// Token: 0x040047C5 RID: 18373
		[Token(Token = "0x40047C5")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<ResourceID, AudioFadeEffect> m_AudioFadeEffects;

		// Token: 0x040047C6 RID: 18374
		[Token(Token = "0x40047C6")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<uint, AudioEngine_Unity.AudioGroup> m_AudioGroupMap;

		// Token: 0x040047C7 RID: 18375
		[Token(Token = "0x40047C7")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<ResourceID, int> m_OneShotCountInFrame;

		// Token: 0x040047C8 RID: 18376
		[Token(Token = "0x40047C8")]
		[FieldOffset(Offset = "0x50")]
		private HashSet<AudioResource> m_RunningAudioResource;

		// Token: 0x040047C9 RID: 18377
		[Token(Token = "0x40047C9")]
		[FieldOffset(Offset = "0x58")]
		private List<GameObject> m_OneShotAudioPool;

		// Token: 0x040047CA RID: 18378
		[Token(Token = "0x40047CA")]
		[FieldOffset(Offset = "0x60")]
		private HashSet<AudioResWithCallBackDefault> m_PlayingAudioResourceWithCallBack;

		// Token: 0x040047CB RID: 18379
		[Token(Token = "0x40047CB")]
		[FieldOffset(Offset = "0x68")]
		private bool m_ChangedSoundEffectVolume;

		// Token: 0x040047CC RID: 18380
		[Token(Token = "0x40047CC")]
		[FieldOffset(Offset = "0x70")]
		private List<ResourceID> m_FinishFadeEffect;

		// Token: 0x040047CD RID: 18381
		[Token(Token = "0x40047CD")]
		[FieldOffset(Offset = "0x78")]
		private List<uint> m_FinishedAudioGroupIDs;

		// Token: 0x040047CE RID: 18382
		[Token(Token = "0x40047CE")]
		[FieldOffset(Offset = "0x80")]
		private GameObject m_OwnedObject;

		// Token: 0x02000EB9 RID: 3769
		[Token(Token = "0x2000EB9")]
		private class AudioGroup
		{
			// Token: 0x060033DB RID: 13275 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60033DB")]
			[Address(RVA = "0x25DD548", Offset = "0x25DD548", VA = "0x7BBCDDD548")]
			public AudioGroup(AudioEngine_Unity owned_engine)
			{
			}

			// Token: 0x060033DC RID: 13276 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60033DC")]
			[Address(RVA = "0x25DC1F8", Offset = "0x25DC1F8", VA = "0x7BBCDDC1F8")]
			public AudioGroup(AudioEngine_Unity owned_engine, int limit_count, int max_range)
			{
			}

			// Token: 0x060033DD RID: 13277 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60033DD")]
			[Address(RVA = "0x25DD600", Offset = "0x25DD600", VA = "0x7BBCDDD600")]
			public void Play3DShot(ResourceID sound, Vector3 worldPos, Vector3 listenerPos, ResourceID audioSourceID, float volume = 1f)
			{
			}

			// Token: 0x060033DE RID: 13278 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60033DE")]
			[Address(RVA = "0x25DF780", Offset = "0x25DF780", VA = "0x7BBCDDF780")]
			public void RunOneFrame(float gameTime, float deltaTime)
			{
			}

			// Token: 0x060033DF RID: 13279 RVA: 0x0000F8D0 File Offset: 0x0000DAD0
			[Token(Token = "0x60033DF")]
			[Address(RVA = "0x25E0AE0", Offset = "0x25E0AE0", VA = "0x7BBCDE0AE0")]
			public bool IsAllFinished()
			{
				return default(bool);
			}

			// Token: 0x060033E0 RID: 13280 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60033E0")]
			[Address(RVA = "0x25DBF68", Offset = "0x25DBF68", VA = "0x7BBCDDBF68")]
			public void Clear()
			{
			}

			// Token: 0x040047CF RID: 18383
			[Token(Token = "0x40047CF")]
			private const float DISTANCE_CHANGE = 5f;

			// Token: 0x040047D0 RID: 18384
			[Token(Token = "0x40047D0")]
			[FieldOffset(Offset = "0x10")]
			private float m_Max_Range;

			// Token: 0x040047D1 RID: 18385
			[Token(Token = "0x40047D1")]
			[FieldOffset(Offset = "0x14")]
			private int m_Limit_Count;

			// Token: 0x040047D2 RID: 18386
			[Token(Token = "0x40047D2")]
			[FieldOffset(Offset = "0x18")]
			private AudioEngine_Unity m_OwnEngine;

			// Token: 0x040047D3 RID: 18387
			[Token(Token = "0x40047D3")]
			[FieldOffset(Offset = "0x20")]
			private HashSet<AudioEngine_Unity.AudioGroup.AudioObject> m_AudioSourceRuningPool;

			// Token: 0x040047D4 RID: 18388
			[Token(Token = "0x40047D4")]
			[FieldOffset(Offset = "0x28")]
			private List<AudioEngine_Unity.AudioGroup.AudioObject> m_FinishedList;

			// Token: 0x02000EBA RID: 3770
			[Token(Token = "0x2000EBA")]
			private class AudioObject
			{
				// Token: 0x060033E1 RID: 13281 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60033E1")]
				[Address(RVA = "0x25E0AD8", Offset = "0x25E0AD8", VA = "0x7BBCDE0AD8")]
				public AudioObject()
				{
				}

				// Token: 0x040047D5 RID: 18389
				[Token(Token = "0x40047D5")]
				[FieldOffset(Offset = "0x10")]
				public AudioSource Audio;

				// Token: 0x040047D6 RID: 18390
				[Token(Token = "0x40047D6")]
				[FieldOffset(Offset = "0x18")]
				public ReusableObject Recyle;

				// Token: 0x040047D7 RID: 18391
				[Token(Token = "0x40047D7")]
				[FieldOffset(Offset = "0x20")]
				public float Distance;
			}
		}
	}
}
