using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EC1 RID: 3777
	[Token(Token = "0x2000EC1")]
	public class AudioManager : MonoBehaviour
	{
		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x060033E6 RID: 13286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000682")]
		public static AudioManager instance
		{
			[Token(Token = "0x60033E6")]
			[Address(RVA = "0x25E0B58", Offset = "0x25E0B58", VA = "0x7BBCDE0B58")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x060033E7 RID: 13287 RVA: 0x0000F8E8 File Offset: 0x0000DAE8
		[Token(Token = "0x17000683")]
		public bool MusicOn
		{
			[Token(Token = "0x60033E7")]
			[Address(RVA = "0x25E0BC0", Offset = "0x25E0BC0", VA = "0x7BBCDE0BC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x060033E8 RID: 13288 RVA: 0x0000F900 File Offset: 0x0000DB00
		[Token(Token = "0x17000684")]
		public bool SoundEffectOn
		{
			[Token(Token = "0x60033E8")]
			[Address(RVA = "0x25E0C38", Offset = "0x25E0C38", VA = "0x7BBCDE0C38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x060033E9 RID: 13289 RVA: 0x0000F918 File Offset: 0x0000DB18
		[Token(Token = "0x17000685")]
		public float MusicVolume
		{
			[Token(Token = "0x60033E9")]
			[Address(RVA = "0x25E0CB0", Offset = "0x25E0CB0", VA = "0x7BBCDE0CB0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060033EA RID: 13290 RVA: 0x0000F930 File Offset: 0x0000DB30
		[Token(Token = "0x17000686")]
		public float SoundEffectVolume
		{
			[Token(Token = "0x60033EA")]
			[Address(RVA = "0x25E0D28", Offset = "0x25E0D28", VA = "0x7BBCDE0D28")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x060033EB RID: 13291 RVA: 0x0000F948 File Offset: 0x0000DB48
		// (set) Token: 0x060033EC RID: 13292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000687")]
		public EAudioEngineType DefaultEngineType
		{
			[Token(Token = "0x60033EB")]
			[Address(RVA = "0x25E0DA0", Offset = "0x25E0DA0", VA = "0x7BBCDE0DA0")]
			get
			{
				return EAudioEngineType.eUnity;
			}
			[Token(Token = "0x60033EC")]
			[Address(RVA = "0x25E0DA8", Offset = "0x25E0DA8", VA = "0x7BBCDE0DA8")]
			set
			{
			}
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x0000F960 File Offset: 0x0000DB60
		[Token(Token = "0x60033ED")]
		[Address(RVA = "0x25E0DB0", Offset = "0x25E0DB0", VA = "0x7BBCDE0DB0")]
		public bool UsedWwiseSound()
		{
			return default(bool);
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033EE")]
		[Address(RVA = "0x25E0DC0", Offset = "0x25E0DC0", VA = "0x7BBCDE0DC0")]
		private void Awake()
		{
		}

		// Token: 0x060033EF RID: 13295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033EF")]
		[Address(RVA = "0x25E1074", Offset = "0x25E1074", VA = "0x7BBCDE1074")]
		private void OnAudioConfigurationChanged(bool deviceWasChanged)
		{
		}

		// Token: 0x060033F0 RID: 13296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F0")]
		[Address(RVA = "0x25E0F04", Offset = "0x25E0F04", VA = "0x7BBCDE0F04")]
		private void InitAudioChannel()
		{
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F1")]
		public static T GetInstanceByEngineType<T>() where T : IAudioEngine
		{
			return null;
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x0000F978 File Offset: 0x0000DB78
		[Token(Token = "0x60033F2")]
		[Address(RVA = "0x25E11A8", Offset = "0x25E11A8", VA = "0x7BBCDE11A8")]
		public static EAudioEngineType GetAudioEngineKeyByType(Type type)
		{
			return EAudioEngineType.eUnity;
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033F3")]
		[Address(RVA = "0x25E1238", Offset = "0x25E1238", VA = "0x7BBCDE1238")]
		private IAudioEngine GetAudioEngineByType(EAudioEngineType target_engine)
		{
			return null;
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F4")]
		[Address(RVA = "0x25E12A0", Offset = "0x25E12A0", VA = "0x7BBCDE12A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F5")]
		[Address(RVA = "0x25E1330", Offset = "0x25E1330", VA = "0x7BBCDE1330")]
		public void RunOneFrame(float gameTime, float deltaTime)
		{
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F6")]
		[Address(RVA = "0x25E13C0", Offset = "0x25E13C0", VA = "0x7BBCDE13C0")]
		public void SetMusicOn(bool v)
		{
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F7")]
		[Address(RVA = "0x25E1440", Offset = "0x25E1440", VA = "0x7BBCDE1440")]
		public void SetMusicVolume(float v)
		{
		}

		// Token: 0x060033F8 RID: 13304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F8")]
		[Address(RVA = "0x25E14C8", Offset = "0x25E14C8", VA = "0x7BBCDE14C8")]
		public void SetSoundEffectVolume(float v)
		{
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033F9")]
		[Address(RVA = "0x25E1560", Offset = "0x25E1560", VA = "0x7BBCDE1560")]
		public void SetSoundEffectOn(bool v)
		{
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FA")]
		[Address(RVA = "0x25E15F4", Offset = "0x25E15F4", VA = "0x7BBCDE15F4")]
		public void OnSettingChanged()
		{
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FB")]
		[Address(RVA = "0x25E166C", Offset = "0x25E166C", VA = "0x7BBCDE166C")]
		public void ClearAllSound()
		{
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FC")]
		[Address(RVA = "0x25E1744", Offset = "0x25E1744", VA = "0x7BBCDE1744")]
		public void OnGameDestory()
		{
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FD")]
		[Address(RVA = "0x25E1748", Offset = "0x25E1748", VA = "0x7BBCDE1748")]
		public void Play3DShot(ResourceID sound, Vector3 worldPos, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default, EAudioEngineType target_engine = EAudioEngineType.eUnity)
		{
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FE")]
		[Address(RVA = "0x25E18DC", Offset = "0x25E18DC", VA = "0x7BBCDE18DC")]
		public void Play3DShot(ResourceID sound, Transform parent, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default, EAudioEngineType target_engine = EAudioEngineType.eUnity)
		{
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FF")]
		[Address(RVA = "0x25E1A60", Offset = "0x25E1A60", VA = "0x7BBCDE1A60")]
		public void InitAudioGroupInfo(uint group_id, int limit_count, int max_range = 25)
		{
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003400")]
		[Address(RVA = "0x25E1AF8", Offset = "0x25E1AF8", VA = "0x7BBCDE1AF8")]
		public void ClearAudioGroupMap()
		{
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003401")]
		[Address(RVA = "0x25E1B70", Offset = "0x25E1B70", VA = "0x7BBCDE1B70")]
		public void Play3DShotWithGroup(uint group_id, ResourceID sound, Vector3 worldPos, Vector3 listenerPos, ResourceID audioSourceID, float volume = 1f)
		{
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003402")]
		[Address(RVA = "0x25E1C60", Offset = "0x25E1C60", VA = "0x7BBCDE1C60")]
		public AudioResource Play2DLoopStart(ResourceID sound, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default, EAudioEngineType target_engine = EAudioEngineType.eUnity)
		{
			return null;
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003403")]
		[Address(RVA = "0x25E1DC8", Offset = "0x25E1DC8", VA = "0x7BBCDE1DC8")]
		public void Play2DLoopStop(AudioResource audioSourceObj, bool fade, bool isNeedUnloadAudioData = false, EAudioEngineType target_engine = EAudioEngineType.eUnity, float volumnChangeSpeed = 1f)
		{
		}

		// Token: 0x06003404 RID: 13316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003404")]
		[Address(RVA = "0x25E1DD4", Offset = "0x25E1DD4", VA = "0x7BBCDE1DD4")]
		private void Play2DLoopStopInternal(AudioResource audioSourceObj, bool fade, bool isNeedUnloadAudioData, EAudioEngineType target_engine, float volumnChangeSpeed = 1f)
		{
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003405")]
		[Address(RVA = "0x25E1EC8", Offset = "0x25E1EC8", VA = "0x7BBCDE1EC8")]
		public GameObject Play3DLoopStart(ResourceID sound, Transform parent, ResourceID audioSourceID, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default, EAudioEngineType target_engine = EAudioEngineType.eUnity)
		{
			return null;
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003406")]
		[Address(RVA = "0x25E2050", Offset = "0x25E2050", VA = "0x7BBCDE2050")]
		public void Play3DLoopStop(GameObject audioSourceObj, EAudioEngineType target_engine = EAudioEngineType.eUnity)
		{
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003407")]
		[Address(RVA = "0x25E2054", Offset = "0x25E2054", VA = "0x7BBCDE2054")]
		private void Play3DLoopStopInternal(GameObject audioSourceObj, EAudioEngineType target_engine)
		{
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003408")]
		[Address(RVA = "0x25E2118", Offset = "0x25E2118", VA = "0x7BBCDE2118")]
		public void PlayOneShotWithChannel(ResourceID sound, EAudioChannel channel, AudioManager.AudioEndCallBack callBack, float volume = 1f, EAudioEngineType target_engine = EAudioEngineType.eUnity)
		{
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003409")]
		[Address(RVA = "0x25E2478", Offset = "0x25E2478", VA = "0x7BBCDE2478")]
		public GameObject PlayOneShot(ResourceID sound, float volume = 1f, ESoundOwner owner_type = ESoundOwner.Default, EAudioEngineType target_engine = EAudioEngineType.eUnity)
		{
			return null;
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600340A")]
		[Address(RVA = "0x25E260C", Offset = "0x25E260C", VA = "0x7BBCDE260C")]
		private AudioResWithCallBackBase PlayOneShotInternal(ResourceID sound, [Optional] AudioEndInternalCallBack callback, float volume = 1f, EAudioEngineType target_engine = EAudioEngineType.eUnity)
		{
			return null;
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600340B")]
		[Address(RVA = "0x25E2774", Offset = "0x25E2774", VA = "0x7BBCDE2774")]
		public void StopPlayShot()
		{
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600340C")]
		[Address(RVA = "0x25E2934", Offset = "0x25E2934", VA = "0x7BBCDE2934")]
		public void StopPlayShot(GameObject obj, EAudioEngineType target_engine = EAudioEngineType.eUnity)
		{
		}

		// Token: 0x0600340D RID: 13325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600340D")]
		[Address(RVA = "0x25E2A2C", Offset = "0x25E2A2C", VA = "0x7BBCDE2A2C")]
		public void StopPlayShotWithChannel(EAudioChannel channel)
		{
		}

		// Token: 0x0600340E RID: 13326 RVA: 0x0000F990 File Offset: 0x0000DB90
		[Token(Token = "0x600340E")]
		[Address(RVA = "0x25E2BC4", Offset = "0x25E2BC4", VA = "0x7BBCDE2BC4")]
		public bool TargetChannelIsPlaying(EAudioChannel channel)
		{
			return default(bool);
		}

		// Token: 0x0600340F RID: 13327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600340F")]
		[Address(RVA = "0x25E2C94", Offset = "0x25E2C94", VA = "0x7BBCDE2C94")]
		private void StopPlayShotInternal(AudioResWithCallBackBase resource, EAudioEngineType target_engine = EAudioEngineType.eUnity)
		{
		}

		// Token: 0x06003410 RID: 13328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003410")]
		[Address(RVA = "0x25E2D5C", Offset = "0x25E2D5C", VA = "0x7BBCDE2D5C")]
		public void PlayMusic(ResourceID sound, bool fadeIn = true, bool fadeOutCurrent = true, bool loop = true, EAudioEngineType target_engine = EAudioEngineType.eUnity, bool isNeedUnloadAudioData = false, bool needContinuePlay = false)
		{
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
		[Token(Token = "0x6003411")]
		[Address(RVA = "0x25E2E70", Offset = "0x25E2E70", VA = "0x7BBCDE2E70")]
		public bool IsCurMusicPlayThisID(ResourceID AudioID, EAudioEngineType target_engine = EAudioEngineType.eUnity)
		{
			return default(bool);
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003412")]
		[Address(RVA = "0x25E2F38", Offset = "0x25E2F38", VA = "0x7BBCDE2F38")]
		public void StopMusic(bool fadeOutCurrent = true, EAudioEngineType target_engine = EAudioEngineType.eUnity, float volumnChangeSpeed = 1f)
		{
		}

		// Token: 0x06003413 RID: 13331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003413")]
		[Address(RVA = "0x25E2F40", Offset = "0x25E2F40", VA = "0x7BBCDE2F40")]
		private void StopMusicInternal(bool fadeOutCurrent, EAudioEngineType target_engine, float volumnChangeSpeed = 1f)
		{
		}

		// Token: 0x06003414 RID: 13332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003414")]
		[Address(RVA = "0x25E3018", Offset = "0x25E3018", VA = "0x7BBCDE3018")]
		public void PlayCurrentMusicFadeEffect(float targetvolume, EAudioEngineType target_engine = EAudioEngineType.eUnity)
		{
		}

		// Token: 0x06003415 RID: 13333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003415")]
		[Address(RVA = "0x25E30E8", Offset = "0x25E30E8", VA = "0x7BBCDE30E8")]
		public void CancelCurrentMusicFadeEffect(EAudioEngineType target_engine = EAudioEngineType.eUnity)
		{
		}

		// Token: 0x06003416 RID: 13334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003416")]
		[Address(RVA = "0x25E31A4", Offset = "0x25E31A4", VA = "0x7BBCDE31A4")]
		public void OnReusableObjectRecycled(ResourceID rID, GameObject obj)
		{
		}

		// Token: 0x06003417 RID: 13335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003417")]
		[Address(RVA = "0x25E3224", Offset = "0x25E3224", VA = "0x7BBCDE3224")]
		public AudioManager()
		{
		}

		// Token: 0x040047F1 RID: 18417
		[Token(Token = "0x40047F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AudioEngine_Unity m_UnityEngine;

		// Token: 0x040047F2 RID: 18418
		[Token(Token = "0x40047F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static AudioManager m_Instance;

		// Token: 0x040047F3 RID: 18419
		[Token(Token = "0x40047F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Dictionary<int, IAudioEngine> m_AudioEngineMap;

		// Token: 0x040047F4 RID: 18420
		[Token(Token = "0x40047F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AudioManager.AudioChannel[] m_ChannelMap;

		// Token: 0x040047F5 RID: 18421
		[Token(Token = "0x40047F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private EAudioEngineType m_DefaultEngineType;

		// Token: 0x02000EC2 RID: 3778
		// (Invoke) Token: 0x0600341A RID: 13338
		[Token(Token = "0x2000EC2")]
		public delegate void AudioEndCallBack(bool end_by_cancle, ResourceID res_id);

		// Token: 0x02000EC3 RID: 3779
		[Token(Token = "0x2000EC3")]
		private enum EAudioType
		{
			// Token: 0x040047F7 RID: 18423
			[Token(Token = "0x40047F7")]
			eOneShot,
			// Token: 0x040047F8 RID: 18424
			[Token(Token = "0x40047F8")]
			e2DLoop,
			// Token: 0x040047F9 RID: 18425
			[Token(Token = "0x40047F9")]
			e3DLoop
		}

		// Token: 0x02000EC4 RID: 3780
		[Token(Token = "0x2000EC4")]
		private class AudioInfo
		{
			// Token: 0x0600341D RID: 13341 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600341D")]
			[Address(RVA = "0x25E3964", Offset = "0x25E3964", VA = "0x7BBCDE3964")]
			public AudioInfo()
			{
			}

			// Token: 0x040047FA RID: 18426
			[Token(Token = "0x40047FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioManager.EAudioType InfoType;

			// Token: 0x040047FB RID: 18427
			[Token(Token = "0x40047FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AudioResWithCallBackBase OwnedResource;

			// Token: 0x040047FC RID: 18428
			[Token(Token = "0x40047FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EAudioEngineType EngineType;

			// Token: 0x040047FD RID: 18429
			[Token(Token = "0x40047FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public ResourceID AudioID;

			// Token: 0x040047FE RID: 18430
			[Token(Token = "0x40047FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioManager.AudioEndCallBack EndCallBack;
		}

		// Token: 0x02000EC5 RID: 3781
		[Token(Token = "0x2000EC5")]
		private class AudioChannel
		{
			// Token: 0x0600341E RID: 13342 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600341E")]
			[Address(RVA = "0x25E1120", Offset = "0x25E1120", VA = "0x7BBCDE1120")]
			public AudioChannel(bool is_single)
			{
			}

			// Token: 0x0600341F RID: 13343 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600341F")]
			[Address(RVA = "0x25E32B8", Offset = "0x25E32B8", VA = "0x7BBCDE32B8")]
			public void OnAudioEnd(AudioResWithCallBackBase audio_resource)
			{
			}

			// Token: 0x06003420 RID: 13344 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003420")]
			[Address(RVA = "0x25E21BC", Offset = "0x25E21BC", VA = "0x7BBCDE21BC")]
			public void PlayOneShot(ResourceID sound, AudioManager.AudioEndCallBack callBack, float volume = 1f, EAudioEngineType target_engine = EAudioEngineType.eUnity)
			{
			}

			// Token: 0x06003421 RID: 13345 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003421")]
			[Address(RVA = "0x25E2A8C", Offset = "0x25E2A8C", VA = "0x7BBCDE2A8C")]
			public void StopChannelAudio()
			{
			}

			// Token: 0x06003422 RID: 13346 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003422")]
			[Address(RVA = "0x25E38C4", Offset = "0x25E38C4", VA = "0x7BBCDE38C4")]
			private void StopAudioWithInfo(AudioManager.AudioInfo info)
			{
			}

			// Token: 0x06003423 RID: 13347 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
			[Token(Token = "0x6003423")]
			[Address(RVA = "0x25E2C28", Offset = "0x25E2C28", VA = "0x7BBCDE2C28")]
			public bool IsPlaying()
			{
				return default(bool);
			}

			// Token: 0x06003424 RID: 13348 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003424")]
			[Address(RVA = "0x25E1740", Offset = "0x25E1740", VA = "0x7BBCDE1740")]
			public void Clean()
			{
			}

			// Token: 0x040047FF RID: 18431
			[Token(Token = "0x40047FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool m_IsSingle;

			// Token: 0x04004800 RID: 18432
			[Token(Token = "0x4004800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private List<AudioManager.AudioInfo> m_CurPlayingAudiolist;
		}
	}
}
