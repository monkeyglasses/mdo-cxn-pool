#region CopyrightHeader
//
//  Copyright by Contributors
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//         http://www.apache.org/licenses/LICENSE-2.0.txt
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace gov.va.medora.mdo
{
    public class Questionnaire
    {
        string name;
        string user;
        string title;
        string description;
        List<QuestionnaireSection> sections;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public List<QuestionnaireSection> Sections
        {
            get { return sections; }
            set { sections = value; }
        }
    }
}
