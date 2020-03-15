namespace Humidifier.MediaLive
{
    using System.Collections.Generic;
    using ChannelTypes;

    public class Channel : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string Inputs =  "Inputs" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::MediaLive::Channel";
            }
        }

        /// <summary>
        /// InputAttachments
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-inputattachments
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: InputAttachment
        /// </summary>
        public List<InputAttachment> InputAttachments
        {
            get;
            set;
        }

        /// <summary>
        /// InputSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-inputspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InputSpecification
        /// </summary>
        public InputSpecification InputSpecification
        {
            get;
            set;
        }

        /// <summary>
        /// ChannelClass
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-channelclass
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ChannelClass
        {
            get;
            set;
        }

        /// <summary>
        /// EncoderSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-encodersettings
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic EncoderSettings
        {
            get;
            set;
        }

        /// <summary>
        /// Destinations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-destinations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: OutputDestination
        /// </summary>
        public List<OutputDestination> Destinations
        {
            get;
            set;
        }

        /// <summary>
        /// LogLevel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-loglevel
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LogLevel
        {
            get;
            set;
        }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Tags
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-medialive-channel.html#cfn-medialive-channel-name
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name
        {
            get;
            set;
        }
    }

    namespace ChannelTypes
    {
        public class MediaPackageOutputDestinationSettings
        {
            /// <summary>
            /// ChannelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-mediapackageoutputdestinationsettings.html#cfn-medialive-channel-mediapackageoutputdestinationsettings-channelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ChannelId
            {
                get;
                set;
            }
        }

        public class HlsInputSettings
        {
            /// <summary>
            /// BufferSegments
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsinputsettings.html#cfn-medialive-channel-hlsinputsettings-buffersegments
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BufferSegments
            {
                get;
                set;
            }

            /// <summary>
            /// Retries
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsinputsettings.html#cfn-medialive-channel-hlsinputsettings-retries
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Retries
            {
                get;
                set;
            }

            /// <summary>
            /// Bandwidth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsinputsettings.html#cfn-medialive-channel-hlsinputsettings-bandwidth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Bandwidth
            {
                get;
                set;
            }

            /// <summary>
            /// RetryInterval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlsinputsettings.html#cfn-medialive-channel-hlsinputsettings-retryinterval
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RetryInterval
            {
                get;
                set;
            }
        }

        public class VideoSelectorProgramId
        {
            /// <summary>
            /// ProgramId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselectorprogramid.html#cfn-medialive-channel-videoselectorprogramid-programid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ProgramId
            {
                get;
                set;
            }
        }

        public class InputAttachment
        {
            /// <summary>
            /// InputAttachmentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputattachment.html#cfn-medialive-channel-inputattachment-inputattachmentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputAttachmentName
            {
                get;
                set;
            }

            /// <summary>
            /// InputId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputattachment.html#cfn-medialive-channel-inputattachment-inputid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputId
            {
                get;
                set;
            }

            /// <summary>
            /// InputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputattachment.html#cfn-medialive-channel-inputattachment-inputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputSettings
            /// </summary>
            public InputSettings InputSettings
            {
                get;
                set;
            }
        }

        public class MultiplexProgramChannelDestinationSettings
        {
            /// <summary>
            /// MultiplexId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexprogramchanneldestinationsettings.html#cfn-medialive-channel-multiplexprogramchanneldestinationsettings-multiplexid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MultiplexId
            {
                get;
                set;
            }

            /// <summary>
            /// ProgramName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-multiplexprogramchanneldestinationsettings.html#cfn-medialive-channel-multiplexprogramchanneldestinationsettings-programname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProgramName
            {
                get;
                set;
            }
        }

        public class EmbeddedSourceSettings
        {
            /// <summary>
            /// Source608ChannelNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-embeddedsourcesettings.html#cfn-medialive-channel-embeddedsourcesettings-source608channelnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Source608ChannelNumber
            {
                get;
                set;
            }

            /// <summary>
            /// Scte20Detection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-embeddedsourcesettings.html#cfn-medialive-channel-embeddedsourcesettings-scte20detection
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Scte20Detection
            {
                get;
                set;
            }

            /// <summary>
            /// Source608TrackNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-embeddedsourcesettings.html#cfn-medialive-channel-embeddedsourcesettings-source608tracknumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Source608TrackNumber
            {
                get;
                set;
            }

            /// <summary>
            /// Convert608To708
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-embeddedsourcesettings.html#cfn-medialive-channel-embeddedsourcesettings-convert608to708
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Convert608To708
            {
                get;
                set;
            }
        }

        public class InputSpecification
        {
            /// <summary>
            /// Codec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputspecification.html#cfn-medialive-channel-inputspecification-codec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Codec
            {
                get;
                set;
            }

            /// <summary>
            /// MaximumBitrate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputspecification.html#cfn-medialive-channel-inputspecification-maximumbitrate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MaximumBitrate
            {
                get;
                set;
            }

            /// <summary>
            /// Resolution
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputspecification.html#cfn-medialive-channel-inputspecification-resolution
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Resolution
            {
                get;
                set;
            }
        }

        public class Scte27SourceSettings
        {
            /// <summary>
            /// Pid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte27sourcesettings.html#cfn-medialive-channel-scte27sourcesettings-pid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Pid
            {
                get;
                set;
            }
        }

        public class VideoSelectorPid
        {
            /// <summary>
            /// Pid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselectorpid.html#cfn-medialive-channel-videoselectorpid-pid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Pid
            {
                get;
                set;
            }
        }

        public class InputSettings
        {
            /// <summary>
            /// DeblockFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-deblockfilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeblockFilter
            {
                get;
                set;
            }

            /// <summary>
            /// FilterStrength
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-filterstrength
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FilterStrength
            {
                get;
                set;
            }

            /// <summary>
            /// InputFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-inputfilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputFilter
            {
                get;
                set;
            }

            /// <summary>
            /// SourceEndBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-sourceendbehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceEndBehavior
            {
                get;
                set;
            }

            /// <summary>
            /// VideoSelector
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-videoselector
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoSelector
            /// </summary>
            public VideoSelector VideoSelector
            {
                get;
                set;
            }

            /// <summary>
            /// AudioSelectors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-audioselectors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: AudioSelector
            /// </summary>
            public List<AudioSelector> AudioSelectors
            {
                get;
                set;
            }

            /// <summary>
            /// CaptionSelectors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-captionselectors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CaptionSelector
            /// </summary>
            public List<CaptionSelector> CaptionSelectors
            {
                get;
                set;
            }

            /// <summary>
            /// DenoiseFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-denoisefilter
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DenoiseFilter
            {
                get;
                set;
            }

            /// <summary>
            /// NetworkInputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-inputsettings.html#cfn-medialive-channel-inputsettings-networkinputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkInputSettings
            /// </summary>
            public NetworkInputSettings NetworkInputSettings
            {
                get;
                set;
            }
        }

        public class AudioSelector
        {
            /// <summary>
            /// SelectorSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioselector.html#cfn-medialive-channel-audioselector-selectorsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioSelectorSettings
            /// </summary>
            public AudioSelectorSettings SelectorSettings
            {
                get;
                set;
            }

            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioselector.html#cfn-medialive-channel-audioselector-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name
            {
                get;
                set;
            }
        }

        public class AudioLanguageSelection
        {
            /// <summary>
            /// LanguageCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiolanguageselection.html#cfn-medialive-channel-audiolanguageselection-languagecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LanguageCode
            {
                get;
                set;
            }

            /// <summary>
            /// LanguageSelectionPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiolanguageselection.html#cfn-medialive-channel-audiolanguageselection-languageselectionpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LanguageSelectionPolicy
            {
                get;
                set;
            }
        }

        public class AribSourceSettings
        {
        }

        public class AudioPidSelection
        {
            /// <summary>
            /// Pid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audiopidselection.html#cfn-medialive-channel-audiopidselection-pid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Pid
            {
                get;
                set;
            }
        }

        public class DvbSubSourceSettings
        {
            /// <summary>
            /// Pid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-dvbsubsourcesettings.html#cfn-medialive-channel-dvbsubsourcesettings-pid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Pid
            {
                get;
                set;
            }
        }

        public class CaptionSelectorSettings
        {
            /// <summary>
            /// DvbSubSourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselectorsettings.html#cfn-medialive-channel-captionselectorsettings-dvbsubsourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DvbSubSourceSettings
            /// </summary>
            public DvbSubSourceSettings DvbSubSourceSettings
            {
                get;
                set;
            }

            /// <summary>
            /// Scte27SourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselectorsettings.html#cfn-medialive-channel-captionselectorsettings-scte27sourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Scte27SourceSettings
            /// </summary>
            public Scte27SourceSettings Scte27SourceSettings
            {
                get;
                set;
            }

            /// <summary>
            /// AribSourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselectorsettings.html#cfn-medialive-channel-captionselectorsettings-aribsourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AribSourceSettings
            /// </summary>
            public AribSourceSettings AribSourceSettings
            {
                get;
                set;
            }

            /// <summary>
            /// EmbeddedSourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselectorsettings.html#cfn-medialive-channel-captionselectorsettings-embeddedsourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EmbeddedSourceSettings
            /// </summary>
            public EmbeddedSourceSettings EmbeddedSourceSettings
            {
                get;
                set;
            }

            /// <summary>
            /// Scte20SourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselectorsettings.html#cfn-medialive-channel-captionselectorsettings-scte20sourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Scte20SourceSettings
            /// </summary>
            public Scte20SourceSettings Scte20SourceSettings
            {
                get;
                set;
            }

            /// <summary>
            /// TeletextSourceSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselectorsettings.html#cfn-medialive-channel-captionselectorsettings-teletextsourcesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TeletextSourceSettings
            /// </summary>
            public TeletextSourceSettings TeletextSourceSettings
            {
                get;
                set;
            }
        }

        public class VideoSelectorSettings
        {
            /// <summary>
            /// VideoSelectorProgramId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselectorsettings.html#cfn-medialive-channel-videoselectorsettings-videoselectorprogramid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoSelectorProgramId
            /// </summary>
            public VideoSelectorProgramId VideoSelectorProgramId
            {
                get;
                set;
            }

            /// <summary>
            /// VideoSelectorPid
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselectorsettings.html#cfn-medialive-channel-videoselectorsettings-videoselectorpid
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoSelectorPid
            /// </summary>
            public VideoSelectorPid VideoSelectorPid
            {
                get;
                set;
            }
        }

        public class TeletextSourceSettings
        {
            /// <summary>
            /// PageNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-teletextsourcesettings.html#cfn-medialive-channel-teletextsourcesettings-pagenumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PageNumber
            {
                get;
                set;
            }
        }

        public class NetworkInputSettings
        {
            /// <summary>
            /// ServerValidation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-networkinputsettings.html#cfn-medialive-channel-networkinputsettings-servervalidation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServerValidation
            {
                get;
                set;
            }

            /// <summary>
            /// HlsInputSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-networkinputsettings.html#cfn-medialive-channel-networkinputsettings-hlsinputsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HlsInputSettings
            /// </summary>
            public HlsInputSettings HlsInputSettings
            {
                get;
                set;
            }
        }

        public class Scte20SourceSettings
        {
            /// <summary>
            /// Source608ChannelNumber
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte20sourcesettings.html#cfn-medialive-channel-scte20sourcesettings-source608channelnumber
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Source608ChannelNumber
            {
                get;
                set;
            }

            /// <summary>
            /// Convert608To708
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-scte20sourcesettings.html#cfn-medialive-channel-scte20sourcesettings-convert608to708
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Convert608To708
            {
                get;
                set;
            }
        }

        public class AudioSelectorSettings
        {
            /// <summary>
            /// AudioPidSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioselectorsettings.html#cfn-medialive-channel-audioselectorsettings-audiopidselection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioPidSelection
            /// </summary>
            public AudioPidSelection AudioPidSelection
            {
                get;
                set;
            }

            /// <summary>
            /// AudioLanguageSelection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-audioselectorsettings.html#cfn-medialive-channel-audioselectorsettings-audiolanguageselection
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AudioLanguageSelection
            /// </summary>
            public AudioLanguageSelection AudioLanguageSelection
            {
                get;
                set;
            }
        }

        public class VideoSelector
        {
            /// <summary>
            /// SelectorSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselector.html#cfn-medialive-channel-videoselector-selectorsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VideoSelectorSettings
            /// </summary>
            public VideoSelectorSettings SelectorSettings
            {
                get;
                set;
            }

            /// <summary>
            /// ColorSpace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselector.html#cfn-medialive-channel-videoselector-colorspace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColorSpace
            {
                get;
                set;
            }

            /// <summary>
            /// ColorSpaceUsage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-videoselector.html#cfn-medialive-channel-videoselector-colorspaceusage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColorSpaceUsage
            {
                get;
                set;
            }
        }

        public class OutputDestinationSettings
        {
            /// <summary>
            /// StreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestinationsettings.html#cfn-medialive-channel-outputdestinationsettings-streamname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamName
            {
                get;
                set;
            }

            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestinationsettings.html#cfn-medialive-channel-outputdestinationsettings-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Username
            {
                get;
                set;
            }

            /// <summary>
            /// PasswordParam
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestinationsettings.html#cfn-medialive-channel-outputdestinationsettings-passwordparam
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PasswordParam
            {
                get;
                set;
            }

            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestinationsettings.html#cfn-medialive-channel-outputdestinationsettings-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url
            {
                get;
                set;
            }
        }

        public class OutputDestination
        {
            /// <summary>
            /// MultiplexSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestination.html#cfn-medialive-channel-outputdestination-multiplexsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MultiplexProgramChannelDestinationSettings
            /// </summary>
            public MultiplexProgramChannelDestinationSettings MultiplexSettings
            {
                get;
                set;
            }

            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestination.html#cfn-medialive-channel-outputdestination-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id
            {
                get;
                set;
            }

            /// <summary>
            /// Settings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestination.html#cfn-medialive-channel-outputdestination-settings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OutputDestinationSettings
            /// </summary>
            public List<OutputDestinationSettings> Settings
            {
                get;
                set;
            }

            /// <summary>
            /// MediaPackageSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-outputdestination.html#cfn-medialive-channel-outputdestination-mediapackagesettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MediaPackageOutputDestinationSettings
            /// </summary>
            public List<MediaPackageOutputDestinationSettings> MediaPackageSettings
            {
                get;
                set;
            }
        }

        public class CaptionSelector
        {
            /// <summary>
            /// LanguageCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselector.html#cfn-medialive-channel-captionselector-languagecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LanguageCode
            {
                get;
                set;
            }

            /// <summary>
            /// SelectorSettings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselector.html#cfn-medialive-channel-captionselector-selectorsettings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CaptionSelectorSettings
            /// </summary>
            public CaptionSelectorSettings SelectorSettings
            {
                get;
                set;
            }

            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-captionselector.html#cfn-medialive-channel-captionselector-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name
            {
                get;
                set;
            }
        }
    }
}